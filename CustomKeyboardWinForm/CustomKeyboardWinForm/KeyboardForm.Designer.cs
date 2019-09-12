namespace CustomKeyboardWinForm
{
    partial class KeyboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.OneButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.BackSpaceButton = new System.Windows.Forms.Button();
            this.PButton = new System.Windows.Forms.Button();
            this.OButton = new System.Windows.Forms.Button();
            this.IButton = new System.Windows.Forms.Button();
            this.UButton = new System.Windows.Forms.Button();
            this.YButton = new System.Windows.Forms.Button();
            this.TButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.WButton = new System.Windows.Forms.Button();
            this.QButton = new System.Windows.Forms.Button();
            this.AButton = new System.Windows.Forms.Button();
            this.SButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.FButton = new System.Windows.Forms.Button();
            this.GButton = new System.Windows.Forms.Button();
            this.HButton = new System.Windows.Forms.Button();
            this.JButton = new System.Windows.Forms.Button();
            this.KButton = new System.Windows.Forms.Button();
            this.LButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.DashButton = new System.Windows.Forms.Button();
            this.MButton = new System.Windows.Forms.Button();
            this.NButton = new System.Windows.Forms.Button();
            this.BButton = new System.Windows.Forms.Button();
            this.VButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.ZButton = new System.Windows.Forms.Button();
            this.SlashButton = new System.Windows.Forms.Button();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.CapsLButton = new System.Windows.Forms.Button();
            this.BackSlashButton = new System.Windows.Forms.Button();
            this.SpaceButton = new System.Windows.Forms.Button();
            this.ClearTextButton = new System.Windows.Forms.Button();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OneButton
            // 
            this.OneButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OneButton.Location = new System.Drawing.Point(0, 21);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(20, 20);
            this.OneButton.TabIndex = 0;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(240, 21);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            this.HeaderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseButton.ForeColor = System.Drawing.Color.Red;
            this.CloseButton.Location = new System.Drawing.Point(215, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 21);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom Keyboard";
            // 
            // TwoButton
            // 
            this.TwoButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TwoButton.Location = new System.Drawing.Point(20, 21);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(20, 20);
            this.TwoButton.TabIndex = 1;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ThreeButton.Location = new System.Drawing.Point(40, 21);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(20, 20);
            this.ThreeButton.TabIndex = 2;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // FourButton
            // 
            this.FourButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FourButton.Location = new System.Drawing.Point(60, 21);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(20, 20);
            this.FourButton.TabIndex = 3;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FiveButton.Location = new System.Drawing.Point(80, 21);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(20, 20);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // SixButton
            // 
            this.SixButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SixButton.Location = new System.Drawing.Point(100, 21);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(20, 20);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SevenButton.Location = new System.Drawing.Point(120, 21);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(20, 20);
            this.SevenButton.TabIndex = 6;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // EightButton
            // 
            this.EightButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EightButton.Location = new System.Drawing.Point(140, 21);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(20, 20);
            this.EightButton.TabIndex = 7;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // NineButton
            // 
            this.NineButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NineButton.Location = new System.Drawing.Point(160, 21);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(20, 20);
            this.NineButton.TabIndex = 8;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZeroButton.Location = new System.Drawing.Point(180, 21);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(20, 20);
            this.ZeroButton.TabIndex = 9;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // BackSpaceButton
            // 
            this.BackSpaceButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackSpaceButton.Location = new System.Drawing.Point(200, 21);
            this.BackSpaceButton.Name = "BackSpaceButton";
            this.BackSpaceButton.Size = new System.Drawing.Size(40, 20);
            this.BackSpaceButton.TabIndex = 10;
            this.BackSpaceButton.Text = "BackS";
            this.BackSpaceButton.UseVisualStyleBackColor = true;
            this.BackSpaceButton.Click += new System.EventHandler(this.BackSpaceButton_Click);
            // 
            // PButton
            // 
            this.PButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PButton.Location = new System.Drawing.Point(194, 42);
            this.PButton.Name = "PButton";
            this.PButton.Size = new System.Drawing.Size(20, 20);
            this.PButton.TabIndex = 20;
            this.PButton.Text = "p";
            this.PButton.UseVisualStyleBackColor = true;
            this.PButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // OButton
            // 
            this.OButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OButton.Location = new System.Drawing.Point(174, 42);
            this.OButton.Name = "OButton";
            this.OButton.Size = new System.Drawing.Size(20, 20);
            this.OButton.TabIndex = 19;
            this.OButton.Text = "o";
            this.OButton.UseVisualStyleBackColor = true;
            this.OButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // IButton
            // 
            this.IButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IButton.Location = new System.Drawing.Point(154, 42);
            this.IButton.Name = "IButton";
            this.IButton.Size = new System.Drawing.Size(20, 20);
            this.IButton.TabIndex = 18;
            this.IButton.Text = "i";
            this.IButton.UseVisualStyleBackColor = true;
            this.IButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // UButton
            // 
            this.UButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UButton.Location = new System.Drawing.Point(134, 42);
            this.UButton.Name = "UButton";
            this.UButton.Size = new System.Drawing.Size(20, 20);
            this.UButton.TabIndex = 17;
            this.UButton.Text = "u";
            this.UButton.UseVisualStyleBackColor = true;
            this.UButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // YButton
            // 
            this.YButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YButton.Location = new System.Drawing.Point(114, 42);
            this.YButton.Name = "YButton";
            this.YButton.Size = new System.Drawing.Size(20, 20);
            this.YButton.TabIndex = 16;
            this.YButton.Text = "y";
            this.YButton.UseVisualStyleBackColor = true;
            this.YButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // TButton
            // 
            this.TButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TButton.Location = new System.Drawing.Point(94, 42);
            this.TButton.Name = "TButton";
            this.TButton.Size = new System.Drawing.Size(20, 20);
            this.TButton.TabIndex = 15;
            this.TButton.Text = "t";
            this.TButton.UseVisualStyleBackColor = true;
            this.TButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // RButton
            // 
            this.RButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RButton.Location = new System.Drawing.Point(74, 42);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(20, 20);
            this.RButton.TabIndex = 14;
            this.RButton.Text = "r";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // EButton
            // 
            this.EButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EButton.Location = new System.Drawing.Point(54, 42);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(20, 20);
            this.EButton.TabIndex = 13;
            this.EButton.Text = "e";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // WButton
            // 
            this.WButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WButton.Location = new System.Drawing.Point(34, 42);
            this.WButton.Name = "WButton";
            this.WButton.Size = new System.Drawing.Size(20, 20);
            this.WButton.TabIndex = 12;
            this.WButton.Text = "w";
            this.WButton.UseVisualStyleBackColor = true;
            this.WButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // QButton
            // 
            this.QButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QButton.Location = new System.Drawing.Point(14, 42);
            this.QButton.Name = "QButton";
            this.QButton.Size = new System.Drawing.Size(20, 20);
            this.QButton.TabIndex = 11;
            this.QButton.Text = "q";
            this.QButton.UseVisualStyleBackColor = true;
            this.QButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // AButton
            // 
            this.AButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AButton.Location = new System.Drawing.Point(25, 63);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(20, 20);
            this.AButton.TabIndex = 22;
            this.AButton.Text = "a";
            this.AButton.UseVisualStyleBackColor = true;
            this.AButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // SButton
            // 
            this.SButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SButton.Location = new System.Drawing.Point(45, 63);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(20, 20);
            this.SButton.TabIndex = 23;
            this.SButton.Text = "s";
            this.SButton.UseVisualStyleBackColor = true;
            this.SButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // DButton
            // 
            this.DButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DButton.Location = new System.Drawing.Point(65, 63);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(20, 20);
            this.DButton.TabIndex = 24;
            this.DButton.Text = "d";
            this.DButton.UseVisualStyleBackColor = true;
            this.DButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // FButton
            // 
            this.FButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FButton.Location = new System.Drawing.Point(85, 63);
            this.FButton.Name = "FButton";
            this.FButton.Size = new System.Drawing.Size(20, 20);
            this.FButton.TabIndex = 25;
            this.FButton.Text = "f";
            this.FButton.UseVisualStyleBackColor = true;
            this.FButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // GButton
            // 
            this.GButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GButton.Location = new System.Drawing.Point(105, 63);
            this.GButton.Name = "GButton";
            this.GButton.Size = new System.Drawing.Size(20, 20);
            this.GButton.TabIndex = 26;
            this.GButton.Text = "g";
            this.GButton.UseVisualStyleBackColor = true;
            this.GButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // HButton
            // 
            this.HButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HButton.Location = new System.Drawing.Point(125, 63);
            this.HButton.Name = "HButton";
            this.HButton.Size = new System.Drawing.Size(20, 20);
            this.HButton.TabIndex = 27;
            this.HButton.Text = "h";
            this.HButton.UseVisualStyleBackColor = true;
            this.HButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // JButton
            // 
            this.JButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.JButton.Location = new System.Drawing.Point(145, 63);
            this.JButton.Name = "JButton";
            this.JButton.Size = new System.Drawing.Size(20, 20);
            this.JButton.TabIndex = 28;
            this.JButton.Text = "j";
            this.JButton.UseVisualStyleBackColor = true;
            this.JButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // KButton
            // 
            this.KButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KButton.Location = new System.Drawing.Point(165, 63);
            this.KButton.Name = "KButton";
            this.KButton.Size = new System.Drawing.Size(20, 20);
            this.KButton.TabIndex = 29;
            this.KButton.Text = "k";
            this.KButton.UseVisualStyleBackColor = true;
            this.KButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // LButton
            // 
            this.LButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LButton.Location = new System.Drawing.Point(185, 63);
            this.LButton.Name = "LButton";
            this.LButton.Size = new System.Drawing.Size(20, 20);
            this.LButton.TabIndex = 30;
            this.LButton.Text = "l";
            this.LButton.UseVisualStyleBackColor = true;
            this.LButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // DotButton
            // 
            this.DotButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DotButton.Location = new System.Drawing.Point(197, 84);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(20, 20);
            this.DotButton.TabIndex = 42;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // DashButton
            // 
            this.DashButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DashButton.Location = new System.Drawing.Point(177, 84);
            this.DashButton.Name = "DashButton";
            this.DashButton.Size = new System.Drawing.Size(20, 20);
            this.DashButton.TabIndex = 41;
            this.DashButton.Text = "-";
            this.DashButton.UseVisualStyleBackColor = true;
            this.DashButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // MButton
            // 
            this.MButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MButton.Location = new System.Drawing.Point(157, 84);
            this.MButton.Name = "MButton";
            this.MButton.Size = new System.Drawing.Size(20, 20);
            this.MButton.TabIndex = 40;
            this.MButton.Text = "m";
            this.MButton.UseVisualStyleBackColor = true;
            this.MButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // NButton
            // 
            this.NButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NButton.Location = new System.Drawing.Point(137, 84);
            this.NButton.Name = "NButton";
            this.NButton.Size = new System.Drawing.Size(20, 20);
            this.NButton.TabIndex = 39;
            this.NButton.Text = "n";
            this.NButton.UseVisualStyleBackColor = true;
            this.NButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // BButton
            // 
            this.BButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BButton.Location = new System.Drawing.Point(117, 84);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(20, 20);
            this.BButton.TabIndex = 38;
            this.BButton.Text = "b";
            this.BButton.UseVisualStyleBackColor = true;
            this.BButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // VButton
            // 
            this.VButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VButton.Location = new System.Drawing.Point(97, 84);
            this.VButton.Name = "VButton";
            this.VButton.Size = new System.Drawing.Size(20, 20);
            this.VButton.TabIndex = 37;
            this.VButton.Text = "v";
            this.VButton.UseVisualStyleBackColor = true;
            this.VButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // CButton
            // 
            this.CButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CButton.Location = new System.Drawing.Point(77, 84);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(20, 20);
            this.CButton.TabIndex = 36;
            this.CButton.Text = "c";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // XButton
            // 
            this.XButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.XButton.Location = new System.Drawing.Point(57, 84);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(20, 20);
            this.XButton.TabIndex = 35;
            this.XButton.Text = "x";
            this.XButton.UseVisualStyleBackColor = true;
            this.XButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // ZButton
            // 
            this.ZButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZButton.Location = new System.Drawing.Point(37, 84);
            this.ZButton.Name = "ZButton";
            this.ZButton.Size = new System.Drawing.Size(20, 20);
            this.ZButton.TabIndex = 34;
            this.ZButton.Text = "z";
            this.ZButton.UseVisualStyleBackColor = true;
            this.ZButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // SlashButton
            // 
            this.SlashButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SlashButton.Location = new System.Drawing.Point(215, 42);
            this.SlashButton.Name = "SlashButton";
            this.SlashButton.Size = new System.Drawing.Size(25, 20);
            this.SlashButton.TabIndex = 21;
            this.SlashButton.Text = "/";
            this.SlashButton.UseVisualStyleBackColor = true;
            this.SlashButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // ShiftButton
            // 
            this.ShiftButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ShiftButton.Location = new System.Drawing.Point(205, 63);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(35, 20);
            this.ShiftButton.TabIndex = 32;
            this.ShiftButton.Text = "Shift";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // CapsLButton
            // 
            this.CapsLButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CapsLButton.Location = new System.Drawing.Point(0, 84);
            this.CapsLButton.Name = "CapsLButton";
            this.CapsLButton.Size = new System.Drawing.Size(37, 20);
            this.CapsLButton.TabIndex = 33;
            this.CapsLButton.Text = "Caps";
            this.CapsLButton.UseVisualStyleBackColor = true;
            this.CapsLButton.Click += new System.EventHandler(this.CapsLButton_Click);
            // 
            // BackSlashButton
            // 
            this.BackSlashButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackSlashButton.Location = new System.Drawing.Point(217, 84);
            this.BackSlashButton.Name = "BackSlashButton";
            this.BackSlashButton.Size = new System.Drawing.Size(23, 20);
            this.BackSlashButton.TabIndex = 43;
            this.BackSlashButton.Text = "\\";
            this.BackSlashButton.UseVisualStyleBackColor = true;
            this.BackSlashButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // SpaceButton
            // 
            this.SpaceButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SpaceButton.Location = new System.Drawing.Point(37, 104);
            this.SpaceButton.Name = "SpaceButton";
            this.SpaceButton.Size = new System.Drawing.Size(180, 20);
            this.SpaceButton.TabIndex = 44;
            this.SpaceButton.Text = " ";
            this.SpaceButton.UseVisualStyleBackColor = true;
            this.SpaceButton.Click += new System.EventHandler(this.btn_Click);
            // 
            // ClearTextButton
            // 
            this.ClearTextButton.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClearTextButton.Location = new System.Drawing.Point(0, 104);
            this.ClearTextButton.Name = "ClearTextButton";
            this.ClearTextButton.Size = new System.Drawing.Size(37, 20);
            this.ClearTextButton.TabIndex = 45;
            this.ClearTextButton.Text = "Clear";
            this.ClearTextButton.UseVisualStyleBackColor = true;
            this.ClearTextButton.Click += new System.EventHandler(this.CleanTextButton_Click);
            // 
            // KeyboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(240, 125);
            this.Controls.Add(this.ClearTextButton);
            this.Controls.Add(this.SpaceButton);
            this.Controls.Add(this.BackSlashButton);
            this.Controls.Add(this.CapsLButton);
            this.Controls.Add(this.ShiftButton);
            this.Controls.Add(this.SlashButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.DashButton);
            this.Controls.Add(this.MButton);
            this.Controls.Add(this.NButton);
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.VButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.ZButton);
            this.Controls.Add(this.PButton);
            this.Controls.Add(this.LButton);
            this.Controls.Add(this.OButton);
            this.Controls.Add(this.KButton);
            this.Controls.Add(this.IButton);
            this.Controls.Add(this.JButton);
            this.Controls.Add(this.UButton);
            this.Controls.Add(this.HButton);
            this.Controls.Add(this.YButton);
            this.Controls.Add(this.GButton);
            this.Controls.Add(this.TButton);
            this.Controls.Add(this.FButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.SButton);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.AButton);
            this.Controls.Add(this.WButton);
            this.Controls.Add(this.QButton);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.BackSpaceButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.OneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(210, 350);
            this.Name = "KeyboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KeyboardForm";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button BackSpaceButton;
        private System.Windows.Forms.Button PButton;
        private System.Windows.Forms.Button OButton;
        private System.Windows.Forms.Button IButton;
        private System.Windows.Forms.Button UButton;
        private System.Windows.Forms.Button YButton;
        private System.Windows.Forms.Button TButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Button WButton;
        private System.Windows.Forms.Button QButton;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Button DButton;
        private System.Windows.Forms.Button FButton;
        private System.Windows.Forms.Button GButton;
        private System.Windows.Forms.Button HButton;
        private System.Windows.Forms.Button JButton;
        private System.Windows.Forms.Button KButton;
        private System.Windows.Forms.Button LButton;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button DashButton;
        private System.Windows.Forms.Button MButton;
        private System.Windows.Forms.Button NButton;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Button VButton;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button ZButton;
        private System.Windows.Forms.Button SlashButton;
        private System.Windows.Forms.Button ShiftButton;
        private System.Windows.Forms.Button CapsLButton;
        private System.Windows.Forms.Button BackSlashButton;
        private System.Windows.Forms.Button SpaceButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearTextButton;
    }
}