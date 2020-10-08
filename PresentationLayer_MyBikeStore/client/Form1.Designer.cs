namespace prjWinForm_MyBike
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSnumber = new System.Windows.Forms.Label();
            this.texboxSerialNumber = new System.Windows.Forms.TextBox();
            this.lbMake = new System.Windows.Forms.Label();
            this.lbSpead = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbMadeDate = new System.Windows.Forms.Label();
            this.lbBikeType = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.textBoxMadeDate_Month = new System.Windows.Forms.TextBox();
            this.textBoxMadeDate_Day = new System.Windows.Forms.TextBox();
            this.textBoxMadeDate_Year = new System.Windows.Forms.TextBox();
            this.comboBox_BikeType = new System.Windows.Forms.ComboBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.listBox_Bike = new System.Windows.Forms.ListBox();
            this.groupBox_MountainBike = new System.Windows.Forms.GroupBox();
            this.comboBox_SuspType = new System.Windows.Forms.ComboBox();
            this.textBox_RiderHeigth = new System.Windows.Forms.TextBox();
            this.textBox_FrameSize = new System.Windows.Forms.TextBox();
            this.lbSuspensionType = new System.Windows.Forms.Label();
            this.lbRiderHeight = new System.Windows.Forms.Label();
            this.lbFrameSize = new System.Windows.Forms.Label();
            this.buttonDisplayMB = new System.Windows.Forms.Button();
            this.groupBox_RoadBike = new System.Windows.Forms.GroupBox();
            this.comboBox_TiresType = new System.Windows.Forms.ComboBox();
            this.comboBox_BrakesType = new System.Windows.Forms.ComboBox();
            this.textBoxSeatTubeHeigth = new System.Windows.Forms.TextBox();
            this.lbTireType = new System.Windows.Forms.Label();
            this.lbBrakesType = new System.Windows.Forms.Label();
            this.lbSeatHeigth = new System.Windows.Forms.Label();
            this.buttonDisplayRB = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.lbSNumberSearch = new System.Windows.Forms.Label();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Color = new System.Windows.Forms.ComboBox();
            this.textBox_Make = new System.Windows.Forms.TextBox();
            this.textBox_Speed = new System.Windows.Forms.TextBox();
            this.button_Saving = new System.Windows.Forms.Button();
            this.button_loading = new System.Windows.Forms.Button();
            this.groupBox_Search = new System.Windows.Forms.GroupBox();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_MountainBike.SuspendLayout();
            this.groupBox_RoadBike.SuspendLayout();
            this.groupBox_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(562, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MyBikes Store";
            // 
            // lbSnumber
            // 
            this.lbSnumber.AutoSize = true;
            this.lbSnumber.Location = new System.Drawing.Point(16, 38);
            this.lbSnumber.Name = "lbSnumber";
            this.lbSnumber.Size = new System.Drawing.Size(90, 15);
            this.lbSnumber.TabIndex = 1;
            this.lbSnumber.Text = "Serial Number:";
            // 
            // texboxSerialNumber
            // 
            this.texboxSerialNumber.AutoCompleteCustomSource.AddRange(new string[] {
            "0000"});
            this.texboxSerialNumber.Location = new System.Drawing.Point(107, 38);
            this.texboxSerialNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.texboxSerialNumber.Name = "texboxSerialNumber";
            this.texboxSerialNumber.Size = new System.Drawing.Size(170, 21);
            this.texboxSerialNumber.TabIndex = 1;
            this.texboxSerialNumber.TextChanged += new System.EventHandler(this.texboxSerialNumber_TextChanged);
            this.texboxSerialNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texboxSerialNumber_KeyPress);
            this.texboxSerialNumber.Validating += new System.ComponentModel.CancelEventHandler(this.texboxSerialNumber_Validating);
            this.texboxSerialNumber.Validated += new System.EventHandler(this.texboxSerialNumber_Validated);
            // 
            // lbMake
            // 
            this.lbMake.AutoSize = true;
            this.lbMake.Location = new System.Drawing.Point(16, 116);
            this.lbMake.Name = "lbMake";
            this.lbMake.Size = new System.Drawing.Size(41, 15);
            this.lbMake.TabIndex = 3;
            this.lbMake.Text = "Make:";
            // 
            // lbSpead
            // 
            this.lbSpead.AutoSize = true;
            this.lbSpead.Location = new System.Drawing.Point(16, 155);
            this.lbSpead.Name = "lbSpead";
            this.lbSpead.Size = new System.Drawing.Size(46, 15);
            this.lbSpead.TabIndex = 6;
            this.lbSpead.Text = "Speed:";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(18, 199);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(39, 15);
            this.lbColor.TabIndex = 7;
            this.lbColor.Text = "Color:";
            // 
            // lbMadeDate
            // 
            this.lbMadeDate.AutoSize = true;
            this.lbMadeDate.Location = new System.Drawing.Point(16, 238);
            this.lbMadeDate.Name = "lbMadeDate";
            this.lbMadeDate.Size = new System.Drawing.Size(71, 15);
            this.lbMadeDate.TabIndex = 8;
            this.lbMadeDate.Text = "Made Date:";
            // 
            // lbBikeType
            // 
            this.lbBikeType.AutoSize = true;
            this.lbBikeType.Location = new System.Drawing.Point(16, 79);
            this.lbBikeType.Name = "lbBikeType";
            this.lbBikeType.Size = new System.Drawing.Size(63, 15);
            this.lbBikeType.TabIndex = 10;
            this.lbBikeType.Text = "Bike Type:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(20, 282);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(59, 15);
            this.lbPrice.TabIndex = 12;
            this.lbPrice.Text = "Price ($): ";
            // 
            // textBoxMadeDate_Month
            // 
            this.textBoxMadeDate_Month.Location = new System.Drawing.Point(110, 230);
            this.textBoxMadeDate_Month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMadeDate_Month.Name = "textBoxMadeDate_Month";
            this.textBoxMadeDate_Month.Size = new System.Drawing.Size(44, 21);
            this.textBoxMadeDate_Month.TabIndex = 6;
            this.textBoxMadeDate_Month.TextChanged += new System.EventHandler(this.textBoxMadeDate_Month_TextChanged);
            this.textBoxMadeDate_Month.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMadeDate_Month_Validating);
            // 
            // textBoxMadeDate_Day
            // 
            this.textBoxMadeDate_Day.Location = new System.Drawing.Point(161, 230);
            this.textBoxMadeDate_Day.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMadeDate_Day.Name = "textBoxMadeDate_Day";
            this.textBoxMadeDate_Day.Size = new System.Drawing.Size(44, 21);
            this.textBoxMadeDate_Day.TabIndex = 7;
            this.textBoxMadeDate_Day.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMadeDate_Day_Validating);
            // 
            // textBoxMadeDate_Year
            // 
            this.textBoxMadeDate_Year.Location = new System.Drawing.Point(212, 230);
            this.textBoxMadeDate_Year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMadeDate_Year.Name = "textBoxMadeDate_Year";
            this.textBoxMadeDate_Year.Size = new System.Drawing.Size(67, 21);
            this.textBoxMadeDate_Year.TabIndex = 8;
            this.textBoxMadeDate_Year.TextChanged += new System.EventHandler(this.textBoxMadeDate_Year_TextChanged);
            this.textBoxMadeDate_Year.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMadeDate_Year_Validating);
            // 
            // comboBox_BikeType
            // 
            this.comboBox_BikeType.FormattingEnabled = true;
            this.comboBox_BikeType.Location = new System.Drawing.Point(107, 74);
            this.comboBox_BikeType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_BikeType.Name = "comboBox_BikeType";
            this.comboBox_BikeType.Size = new System.Drawing.Size(170, 23);
            this.comboBox_BikeType.TabIndex = 2;
            this.comboBox_BikeType.SelectedIndexChanged += new System.EventHandler(this.comboBox_BikeType_SelectedIndexChanged);
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(110, 278);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(170, 21);
            this.textBox_Price.TabIndex = 9;
            this.textBox_Price.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Price_Validating);
            // 
            // listBox_Bike
            // 
            this.listBox_Bike.ItemHeight = 15;
            this.listBox_Bike.Location = new System.Drawing.Point(24, 358);
            this.listBox_Bike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox_Bike.Name = "listBox_Bike";
            this.listBox_Bike.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox_Bike.ScrollAlwaysVisible = true;
            this.listBox_Bike.Size = new System.Drawing.Size(1033, 334);
            this.listBox_Bike.TabIndex = 26;
            this.listBox_Bike.SelectedIndexChanged += new System.EventHandler(this.listBox_Bike_SelectedIndexChanged);
            // 
            // groupBox_MountainBike
            // 
            this.groupBox_MountainBike.Controls.Add(this.comboBox_SuspType);
            this.groupBox_MountainBike.Controls.Add(this.textBox_RiderHeigth);
            this.groupBox_MountainBike.Controls.Add(this.textBox_FrameSize);
            this.groupBox_MountainBike.Controls.Add(this.lbSuspensionType);
            this.groupBox_MountainBike.Controls.Add(this.lbRiderHeight);
            this.groupBox_MountainBike.Controls.Add(this.lbFrameSize);
            this.groupBox_MountainBike.Location = new System.Drawing.Point(292, 35);
            this.groupBox_MountainBike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_MountainBike.Name = "groupBox_MountainBike";
            this.groupBox_MountainBike.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_MountainBike.Size = new System.Drawing.Size(334, 179);
            this.groupBox_MountainBike.TabIndex = 24;
            this.groupBox_MountainBike.TabStop = false;
            this.groupBox_MountainBike.Text = "MountainBike";
            // 
            // comboBox_SuspType
            // 
            this.comboBox_SuspType.FormattingEnabled = true;
            this.comboBox_SuspType.Location = new System.Drawing.Point(134, 131);
            this.comboBox_SuspType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_SuspType.Name = "comboBox_SuspType";
            this.comboBox_SuspType.Size = new System.Drawing.Size(170, 23);
            this.comboBox_SuspType.TabIndex = 12;
            this.comboBox_SuspType.SelectedIndexChanged += new System.EventHandler(this.comboBox_SuspType_SelectedIndexChanged);
            // 
            // textBox_RiderHeigth
            // 
            this.textBox_RiderHeigth.Location = new System.Drawing.Point(134, 83);
            this.textBox_RiderHeigth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_RiderHeigth.Name = "textBox_RiderHeigth";
            this.textBox_RiderHeigth.Size = new System.Drawing.Size(170, 21);
            this.textBox_RiderHeigth.TabIndex = 11;
            this.textBox_RiderHeigth.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_RiderHeigth_Validating);
            // 
            // textBox_FrameSize
            // 
            this.textBox_FrameSize.Location = new System.Drawing.Point(134, 36);
            this.textBox_FrameSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FrameSize.Name = "textBox_FrameSize";
            this.textBox_FrameSize.Size = new System.Drawing.Size(170, 21);
            this.textBox_FrameSize.TabIndex = 10;
            this.textBox_FrameSize.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_FrameSize_Validating);
            // 
            // lbSuspensionType
            // 
            this.lbSuspensionType.AutoSize = true;
            this.lbSuspensionType.Location = new System.Drawing.Point(13, 139);
            this.lbSuspensionType.Name = "lbSuspensionType";
            this.lbSuspensionType.Size = new System.Drawing.Size(104, 15);
            this.lbSuspensionType.TabIndex = 2;
            this.lbSuspensionType.Text = "Suspension Type:";
            // 
            // lbRiderHeight
            // 
            this.lbRiderHeight.AutoSize = true;
            this.lbRiderHeight.Location = new System.Drawing.Point(13, 86);
            this.lbRiderHeight.Name = "lbRiderHeight";
            this.lbRiderHeight.Size = new System.Drawing.Size(107, 15);
            this.lbRiderHeight.TabIndex = 1;
            this.lbRiderHeight.Text = "Rider Heigth (cm):";
            // 
            // lbFrameSize
            // 
            this.lbFrameSize.AutoSize = true;
            this.lbFrameSize.Location = new System.Drawing.Point(13, 43);
            this.lbFrameSize.Name = "lbFrameSize";
            this.lbFrameSize.Size = new System.Drawing.Size(101, 15);
            this.lbFrameSize.TabIndex = 0;
            this.lbFrameSize.Text = "Frame Size (cm):";
            // 
            // buttonDisplayMB
            // 
            this.buttonDisplayMB.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDisplayMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayMB.Location = new System.Drawing.Point(1072, 461);
            this.buttonDisplayMB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDisplayMB.Name = "buttonDisplayMB";
            this.buttonDisplayMB.Size = new System.Drawing.Size(146, 45);
            this.buttonDisplayMB.TabIndex = 22;
            this.buttonDisplayMB.Text = "DISPLAY Mountain bikes";
            this.buttonDisplayMB.UseVisualStyleBackColor = false;
            this.buttonDisplayMB.Click += new System.EventHandler(this.buttonDisplayMB_Click);
            // 
            // groupBox_RoadBike
            // 
            this.groupBox_RoadBike.Controls.Add(this.comboBox_TiresType);
            this.groupBox_RoadBike.Controls.Add(this.comboBox_BrakesType);
            this.groupBox_RoadBike.Controls.Add(this.textBoxSeatTubeHeigth);
            this.groupBox_RoadBike.Controls.Add(this.lbTireType);
            this.groupBox_RoadBike.Controls.Add(this.lbBrakesType);
            this.groupBox_RoadBike.Controls.Add(this.lbSeatHeigth);
            this.groupBox_RoadBike.Location = new System.Drawing.Point(632, 35);
            this.groupBox_RoadBike.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_RoadBike.Name = "groupBox_RoadBike";
            this.groupBox_RoadBike.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_RoadBike.Size = new System.Drawing.Size(320, 179);
            this.groupBox_RoadBike.TabIndex = 25;
            this.groupBox_RoadBike.TabStop = false;
            this.groupBox_RoadBike.Text = "Road Bike";
            // 
            // comboBox_TiresType
            // 
            this.comboBox_TiresType.FormattingEnabled = true;
            this.comboBox_TiresType.Location = new System.Drawing.Point(118, 128);
            this.comboBox_TiresType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_TiresType.Name = "comboBox_TiresType";
            this.comboBox_TiresType.Size = new System.Drawing.Size(170, 23);
            this.comboBox_TiresType.TabIndex = 15;
            this.comboBox_TiresType.SelectedIndexChanged += new System.EventHandler(this.comboBox_TiresType_SelectedIndexChanged);
            // 
            // comboBox_BrakesType
            // 
            this.comboBox_BrakesType.FormattingEnabled = true;
            this.comboBox_BrakesType.Location = new System.Drawing.Point(118, 86);
            this.comboBox_BrakesType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_BrakesType.Name = "comboBox_BrakesType";
            this.comboBox_BrakesType.Size = new System.Drawing.Size(170, 23);
            this.comboBox_BrakesType.TabIndex = 14;
            this.comboBox_BrakesType.SelectedIndexChanged += new System.EventHandler(this.comboBox_BrakesType_SelectedIndexChanged);
            // 
            // textBoxSeatTubeHeigth
            // 
            this.textBoxSeatTubeHeigth.Location = new System.Drawing.Point(118, 40);
            this.textBoxSeatTubeHeigth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSeatTubeHeigth.Name = "textBoxSeatTubeHeigth";
            this.textBoxSeatTubeHeigth.Size = new System.Drawing.Size(170, 21);
            this.textBoxSeatTubeHeigth.TabIndex = 13;
            this.textBoxSeatTubeHeigth.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSeatTubeHeigth_Validating);
            // 
            // lbTireType
            // 
            this.lbTireType.AutoSize = true;
            this.lbTireType.Location = new System.Drawing.Point(17, 126);
            this.lbTireType.Name = "lbTireType";
            this.lbTireType.Size = new System.Drawing.Size(62, 15);
            this.lbTireType.TabIndex = 6;
            this.lbTireType.Text = "Tires type:";
            // 
            // lbBrakesType
            // 
            this.lbBrakesType.AutoSize = true;
            this.lbBrakesType.Location = new System.Drawing.Point(17, 91);
            this.lbBrakesType.Name = "lbBrakesType";
            this.lbBrakesType.Size = new System.Drawing.Size(73, 15);
            this.lbBrakesType.TabIndex = 5;
            this.lbBrakesType.Text = "Brakes type:";
            // 
            // lbSeatHeigth
            // 
            this.lbSeatHeigth.AutoSize = true;
            this.lbSeatHeigth.Location = new System.Drawing.Point(17, 45);
            this.lbSeatHeigth.Name = "lbSeatHeigth";
            this.lbSeatHeigth.Size = new System.Drawing.Size(99, 15);
            this.lbSeatHeigth.TabIndex = 0;
            this.lbSeatHeigth.Text = "SeatHeight (cm):";
            this.lbSeatHeigth.Click += new System.EventHandler(this.label15_Click);
            // 
            // buttonDisplayRB
            // 
            this.buttonDisplayRB.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDisplayRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayRB.Location = new System.Drawing.Point(1072, 398);
            this.buttonDisplayRB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDisplayRB.Name = "buttonDisplayRB";
            this.buttonDisplayRB.Size = new System.Drawing.Size(146, 44);
            this.buttonDisplayRB.TabIndex = 21;
            this.buttonDisplayRB.Text = "DISPLAY Road bikes";
            this.buttonDisplayRB.UseVisualStyleBackColor = false;
            this.buttonDisplayRB.Click += new System.EventHandler(this.buttonDisplayRB_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(1072, 43);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 44);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(1072, 108);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(146, 47);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "RESET";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(224, 67);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(146, 38);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(23, 75);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(163, 21);
            this.textBoxSearch.TabIndex = 27;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSearch_Validating);
            // 
            // lbSNumberSearch
            // 
            this.lbSNumberSearch.AutoSize = true;
            this.lbSNumberSearch.Location = new System.Drawing.Point(49, 56);
            this.lbSNumberSearch.Name = "lbSNumberSearch";
            this.lbSNumberSearch.Size = new System.Drawing.Size(115, 15);
            this.lbSNumberSearch.TabIndex = 32;
            this.lbSNumberSearch.Text = "Enter serial number";
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.Location = new System.Drawing.Point(1072, 177);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(146, 47);
            this.buttonDisplay.TabIndex = 18;
            this.buttonDisplay.Text = "DISPLAY ";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(1072, 323);
            this.butDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(146, 47);
            this.butDelete.TabIndex = 20;
            this.butDelete.Text = "DELETE";
            this.butDelete.UseVisualStyleBackColor = false;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.butUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Location = new System.Drawing.Point(1072, 248);
            this.butUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(146, 47);
            this.butUpdate.TabIndex = 19;
            this.butUpdate.Text = "UPDATE";
            this.butUpdate.UseVisualStyleBackColor = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1072, 660);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(146, 47);
            this.buttonExit.TabIndex = 25;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(112, 254);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(42, 15);
            this.label23.TabIndex = 40;
            this.label23.Text = "month";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(170, 254);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 15);
            this.label24.TabIndex = 41;
            this.label24.Text = "day";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(230, 253);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 15);
            this.label25.TabIndex = 42;
            this.label25.Text = "year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(824, 711);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "(prepared by Kryukova Svetlana)";
            // 
            // comboBox_Color
            // 
            this.comboBox_Color.FormattingEnabled = true;
            this.comboBox_Color.Location = new System.Drawing.Point(107, 188);
            this.comboBox_Color.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Color.Name = "comboBox_Color";
            this.comboBox_Color.Size = new System.Drawing.Size(170, 23);
            this.comboBox_Color.TabIndex = 5;
            this.comboBox_Color.SelectedIndexChanged += new System.EventHandler(this.comboBox_Color_SelectedIndexChanged);
            // 
            // textBox_Make
            // 
            this.textBox_Make.Location = new System.Drawing.Point(107, 112);
            this.textBox_Make.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Make.Name = "textBox_Make";
            this.textBox_Make.Size = new System.Drawing.Size(170, 21);
            this.textBox_Make.TabIndex = 3;
            this.textBox_Make.TextChanged += new System.EventHandler(this.textBox_Make_TextChanged);
            this.textBox_Make.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Make_Validating);
            // 
            // textBox_Speed
            // 
            this.textBox_Speed.Location = new System.Drawing.Point(107, 152);
            this.textBox_Speed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Speed.Name = "textBox_Speed";
            this.textBox_Speed.Size = new System.Drawing.Size(172, 21);
            this.textBox_Speed.TabIndex = 4;
            this.textBox_Speed.TextChanged += new System.EventHandler(this.textBox_Speed_TextChanged);
            this.textBox_Speed.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Speed_Validating);
            // 
            // button_Saving
            // 
            this.button_Saving.BackColor = System.Drawing.SystemColors.Info;
            this.button_Saving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Saving.Location = new System.Drawing.Point(1072, 522);
            this.button_Saving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Saving.Name = "button_Saving";
            this.button_Saving.Size = new System.Drawing.Size(146, 47);
            this.button_Saving.TabIndex = 23;
            this.button_Saving.Text = "WRITE to File";
            this.button_Saving.UseVisualStyleBackColor = false;
            this.button_Saving.Click += new System.EventHandler(this.button_Saving_Click);
            // 
            // button_loading
            // 
            this.button_loading.BackColor = System.Drawing.SystemColors.Info;
            this.button_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loading.Location = new System.Drawing.Point(1072, 589);
            this.button_loading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_loading.Name = "button_loading";
            this.button_loading.Size = new System.Drawing.Size(146, 47);
            this.button_loading.TabIndex = 24;
            this.button_loading.Text = "READ from File";
            this.button_loading.UseVisualStyleBackColor = false;
            this.button_loading.Click += new System.EventHandler(this.button_LoadingFile_Click);
            // 
            // groupBox_Search
            // 
            this.groupBox_Search.Controls.Add(this.lbSNumberSearch);
            this.groupBox_Search.Controls.Add(this.textBoxSearch);
            this.groupBox_Search.Controls.Add(this.buttonSearch);
            this.groupBox_Search.Location = new System.Drawing.Point(426, 221);
            this.groupBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Search.Name = "groupBox_Search";
            this.groupBox_Search.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_Search.Size = new System.Drawing.Size(395, 119);
            this.groupBox_Search.TabIndex = 50;
            this.groupBox_Search.TabStop = false;
            this.groupBox_Search.Text = "Search for a bike into the list";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "My bikes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1241, 738);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox_Search);
            this.Controls.Add(this.button_loading);
            this.Controls.Add(this.button_Saving);
            this.Controls.Add(this.textBox_Speed);
            this.Controls.Add(this.textBox_Make);
            this.Controls.Add(this.comboBox_Color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.buttonDisplayRB);
            this.Controls.Add(this.buttonDisplayMB);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox_RoadBike);
            this.Controls.Add(this.groupBox_MountainBike);
            this.Controls.Add(this.listBox_Bike);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.comboBox_BikeType);
            this.Controls.Add(this.textBoxMadeDate_Year);
            this.Controls.Add(this.textBoxMadeDate_Day);
            this.Controls.Add(this.textBoxMadeDate_Month);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbBikeType);
            this.Controls.Add(this.lbMadeDate);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.lbSpead);
            this.Controls.Add(this.lbMake);
            this.Controls.Add(this.texboxSerialNumber);
            this.Controls.Add(this.lbSnumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBike Store ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_MountainBike.ResumeLayout(false);
            this.groupBox_MountainBike.PerformLayout();
            this.groupBox_RoadBike.ResumeLayout(false);
            this.groupBox_RoadBike.PerformLayout();
            this.groupBox_Search.ResumeLayout(false);
            this.groupBox_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSnumber;
        private System.Windows.Forms.TextBox texboxSerialNumber;
        private System.Windows.Forms.Label lbMake;
        private System.Windows.Forms.Label lbSpead;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbMadeDate;
        private System.Windows.Forms.Label lbBikeType;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox textBoxMadeDate_Month;
        private System.Windows.Forms.TextBox textBoxMadeDate_Day;
        private System.Windows.Forms.TextBox textBoxMadeDate_Year;
        private System.Windows.Forms.ComboBox comboBox_BikeType;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.ListBox listBox_Bike;
        private System.Windows.Forms.GroupBox groupBox_MountainBike;
        private System.Windows.Forms.GroupBox groupBox_RoadBike;
        private System.Windows.Forms.Label lbSuspensionType;
        private System.Windows.Forms.Label lbRiderHeight;
        private System.Windows.Forms.Label lbFrameSize;
        private System.Windows.Forms.TextBox textBox_FrameSize;
        private System.Windows.Forms.ComboBox comboBox_SuspType;
        private System.Windows.Forms.TextBox textBox_RiderHeigth;
        private System.Windows.Forms.TextBox textBoxSeatTubeHeigth;
        private System.Windows.Forms.Label lbTireType;
        private System.Windows.Forms.Label lbBrakesType;
        private System.Windows.Forms.Label lbSeatHeigth;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label lbSNumberSearch;
        private System.Windows.Forms.Button buttonDisplayMB;
        private System.Windows.Forms.Button buttonDisplayRB;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_TiresType;
        private System.Windows.Forms.ComboBox comboBox_BrakesType;
        private System.Windows.Forms.ComboBox comboBox_Color;
        private System.Windows.Forms.TextBox textBox_Make;
        private System.Windows.Forms.TextBox textBox_Speed;
        private System.Windows.Forms.Button button_Saving;
        private System.Windows.Forms.Button button_loading;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.ErrorProvider errorProviderApp;
        private System.Windows.Forms.Label label2;
    }
}

