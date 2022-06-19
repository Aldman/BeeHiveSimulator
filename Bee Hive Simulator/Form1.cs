using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;


namespace Bee_Hive_Simulator
{
    public partial class Form1 : Form
    {
        HiveForm hiveForm = new HiveForm();
        FieldForm fieldForm = new FieldForm();

        World world;
        Renderer renderer;

        Random random = new Random();
        DateTime start = DateTime.Now;
        DateTime end;
        int framesRun;

        public Form1()
        {
            InitializeComponent();

            MoveChildForms();
            hiveForm.Show(this);
            fieldForm.Show(this);
            ResetSimulator();

            timer1.Interval = 50;
            timer1.Tick += new EventHandler(RunFrame);
            timer1.Enabled = false;
            UpdateStats(new TimeSpan());
        }

        private void MoveChildForms()
        {
            hiveForm.Location = new Point(Location.X + Width + 10, Location.Y);
            fieldForm.Location = new Point(Location.X,
                Location.Y + Math.Max(Height, hiveForm.Height) + 10);
        }

        private void ResetSimulator()
        {
            framesRun = 0;
            world = new World(SendMessage);
            renderer = new Renderer(world, hiveForm, fieldForm);
        }

        private void UpdateStats(TimeSpan frameDuration)
        {
            Bees.Text = world.Bees.Count.ToString();
            Flowers.Text = world.Flowers.Count.ToString();
            HoneyInHive.Text = String.Format("{0:f3}", world.Hive.Honey);
            double nectar = 0;
            foreach (Flower flower in world.Flowers)
                nectar += flower.Nectar;
            NectarInFlowers.Text = String.Format("{0:f3}", nectar);
            FramesRun.Text = framesRun.ToString();
            double milliSeconds = frameDuration.TotalMilliseconds;
            if (milliSeconds != 0.0)
                FrameRate.Text = String.Format("{0:f0} ({1:f1}ms)",
                    1000 / milliSeconds, milliSeconds);
            else FrameRate.Text = "N/A";
        }

        public void RunFrame(object sender, EventArgs e)
        {
            framesRun++;
            world.Go(random);
            end = DateTime.Now;
            TimeSpan frameDuration = end - start;
            start = end;
            UpdateStats(frameDuration);
            hiveForm.Invalidate();
            fieldForm.Invalidate();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            MoveChildForms();
        }

        private void btStartSimulation_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                btStartSimulation.Text = "Resume Simulation";
                timer1.Stop();
            }
            else
            {
                btStartSimulation.Text = "Pause Simulation";
                timer1.Start();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetSimulator();
            if (!timer1.Enabled)
                btStartSimulation.Text = "Start Simulation";
        }

        private void SendMessage(int ID, string Message)
        {
            statusStrip1.Items[0].Text = "Bee #" + ID + ":" + Message;

            var beeGroups =
                from bee in world.Bees
                group bee by bee.CurrentState into beeGroup
                orderby beeGroup.Key
                select beeGroup;

            lb1.Items.Clear();

            foreach (var group in beeGroups)
            {
                string s;
                if (group.Count() == 1)
                    s = "";
                else
                    s = "s";

                lb1.Items.Add(group.Key.ToString() + ": "
                    + group.Count() + " bee" + s);

                if (group.Key == BeeState.Idle
                    && group.Count() == world.Bees.Count
                    && framesRun > 0)
                {
                    lb1.Items.Add("Simulation ended: all bees are idle");
                    toolStrip1.Items[0].Text = "Simulation ended";
                    statusStrip1.Items[0].Text = "Simulation ended";
                    timer1.Enabled = false;
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            World currentWorld = world;
            int currentFramesRun = framesRun;

            bool enabled = timer1.Enabled;
            if (enabled)
                timer1.Stop();

            OpenFileDialog openFD = new OpenFileDialog()
            {
                Filter = "Simulator File (*.bees)|*.bees",
                CheckPathExists = true,
                CheckFileExists = true,
                Title = "Choose a file with a simulation to load"
            };

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream input = File.OpenRead(openFD.FileName))
                    {
                        world = (World)bf.Deserialize(input);
                        framesRun = (int)bf.Deserialize(input);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open chosen file\r\n" + ex.Message,
                        "Bee Simulator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    framesRun = currentFramesRun;
                    world = currentWorld;
                }
            }

            world.Hive.MessageSender = SendMessage;
            foreach (var bee in world.Bees)
                bee.MessageSender = SendMessage;

            if (enabled)
                timer1.Start();

            renderer = new Renderer(world, hiveForm, fieldForm);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            bool enabled = timer1.Enabled;
            if (enabled)
                timer1.Stop();

            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.Filter = "Simulator File (*.bees)|*.bees";
            saveFD.CheckPathExists = true;
            saveFD.Title = "Choose a file to save the current simulation";
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (Stream output = File.OpenWrite(saveFD.FileName))
                    {
                        bf.Serialize(output, world);
                        bf.Serialize(output, framesRun);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save the simulator file\r\n" + ex.Message,
                        "Bee Simulator Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (enabled)
                timer1.Start();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            renderer.AnimateBees();
        }








    }
}
