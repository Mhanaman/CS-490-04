using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using TwinCAT.Ads;

namespace Sample02
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.ComboBox tbInt;
        private System.Windows.Forms.ComboBox tbDint;
        private System.Windows.Forms.ComboBox tbByte;
        private System.Windows.Forms.ComboBox tbLReal;
        private System.Windows.Forms.ComboBox tbReal;
        private System.Windows.Forms.ComboBox tbTest;

        private System.ComponentModel.Container components = null;

        private int hVar;
        private TcAdsClient tcClient;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbInt = new System.Windows.Forms.ComboBox();
            this.tbDint = new System.Windows.Forms.ComboBox();
            this.tbByte = new System.Windows.Forms.ComboBox();
            this.tbLReal = new System.Windows.Forms.ComboBox();
            this.tbReal = new System.Windows.Forms.ComboBox();
            this.tbTest = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInt
            // 
            this.tbInt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbInt.Items.AddRange(new object[] {
            "1000",
            "2000"});
            this.tbInt.Location = new System.Drawing.Point(86, 37);
            this.tbInt.Name = "tbInt";
            this.tbInt.Size = new System.Drawing.Size(120, 24);
            this.tbInt.TabIndex = 0;
            // 
            // tbDint
            // 
            this.tbDint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbDint.Items.AddRange(new object[] {
            "10000",
            "20000"});
            this.tbDint.Location = new System.Drawing.Point(86, 74);
            this.tbDint.Name = "tbDint";
            this.tbDint.Size = new System.Drawing.Size(120, 24);
            this.tbDint.TabIndex = 1;
            // 
            // tbByte
            // 
            this.tbByte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbByte.Items.AddRange(new object[] {
            "100",
            "200"});
            this.tbByte.Location = new System.Drawing.Point(86, 111);
            this.tbByte.Name = "tbByte";
            this.tbByte.Size = new System.Drawing.Size(120, 24);
            this.tbByte.TabIndex = 2;
            // 
            // tbLReal
            // 
            this.tbLReal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbLReal.Items.AddRange(new object[] {
            "3,145",
            "2,654"});
            this.tbLReal.Location = new System.Drawing.Point(86, 148);
            this.tbLReal.Name = "tbLReal";
            this.tbLReal.Size = new System.Drawing.Size(120, 24);
            this.tbLReal.TabIndex = 3;
            // 
            // tbReal
            // 
            this.tbReal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbReal.Items.AddRange(new object[] {
            "3,14",
            "1,59"});
            this.tbReal.Location = new System.Drawing.Point(86, 185);
            this.tbReal.Name = "tbReal";
            this.tbReal.Size = new System.Drawing.Size(120, 24);
            this.tbReal.TabIndex = 4;
            // 
            // tbTest
            // 
            this.tbTest.Location = new System.Drawing.Point(86, 222);
            this.tbTest.Name = "tbTest";
            this.tbTest.Size = new System.Drawing.Size(120, 24);
            this.tbTest.TabIndex = 10;
            this.tbTest.Text = "Does this work?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbByte);
            this.groupBox1.Controls.Add(this.tbDint);
            this.groupBox1.Controls.Add(this.tbInt);
            this.groupBox1.Controls.Add(this.tbLReal);
            this.groupBox1.Controls.Add(this.tbReal);
            this.groupBox1.Controls.Add(this.tbTest);
            this.groupBox1.Location = new System.Drawing.Point(19, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLCStruct";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Please work :";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "realVal :";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "lrealVal :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "byteVal :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "dintVal :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "intVal :";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(19, 286);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(231, 28);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Write";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(19, 350);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(231, 28);
            this.display.TabIndex = 7;
            this.display.Text = "Display";
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(416, 469);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.display);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sample02";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
            

            //System.Console.WriteLine("Contents of Testing.txt = {0}", text);

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            tcClient = new TcAdsClient();
            tcClient.Connect(851);
            try
            {
                hVar = tcClient.CreateVariableHandle("MAIN.PLCVar");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnWrite_Click(object sender, System.EventArgs e)
        {
            AdsStream dataStream = new AdsStream(32);
            BinaryWriter binWrite = new BinaryWriter(dataStream);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Jake\Documents\Jake's Stuff\College\CS 490-491\Testing.txt");
            string testing = lines[0];

            dataStream.Position = 0;
            try
            {
                // Adjust datastream.position for 8 byte-alignment

                binWrite.Write(short.Parse(tbInt.Text));
                dataStream.Position = 4;
                binWrite.Write(int.Parse(tbDint.Text));
                dataStream.Position = 8;
                binWrite.Write(byte.Parse(tbByte.Text));
                dataStream.Position = 16;
                binWrite.Write(double.Parse(tbLReal.Text));
                dataStream.Position = 24;
                binWrite.Write(float.Parse(tbReal.Text));

                tcClient.Write(hVar, dataStream);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void display_Click(object sender, System.EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Jake\Documents\Jake's Stuff\College\CS 490-491\Testing.txt");

            string text = lines[0];
            /*System.Console.WriteLine("Contents of Testing.txt = ");
            foreach (string line in lines)
            {
                System.Console.WriteLine("\t" + line);
            }
            System.Console.ReadKey();*/

            MessageBox.Show(text);
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Resourcen wieder freigeben
            try
            {
                tcClient.DeleteVariableHandle(hVar);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            tcClient.Dispose();
        }
    }
}
