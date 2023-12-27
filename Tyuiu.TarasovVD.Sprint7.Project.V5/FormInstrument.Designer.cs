
namespace Tyuiu.TarasovVD.Sprint7.Project.V5
{
    partial class FormInstrument
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReturn_TVD = new System.Windows.Forms.Button();
            this.buttonEditHeaders_TVD = new System.Windows.Forms.Button();
            this.buttonHelp_TVD = new System.Windows.Forms.Button();
            this.buttonSaveFile_TVD = new System.Windows.Forms.Button();
            this.buttonOpenFile_TVD = new System.Windows.Forms.Button();
            this.buttonStats_TVD = new System.Windows.Forms.Button();
            this.labelSearch_TVD = new System.Windows.Forms.Label();
            this.textBoxSearch_TVD = new System.Windows.Forms.TextBox();
            this.panelLeft_TVD = new System.Windows.Forms.Panel();
            this.groupBoxStats_TVD = new System.Windows.Forms.GroupBox();
            this.textBoxSort_TVD = new System.Windows.Forms.TextBox();
            this.buttonSortNumberProduct_TVD = new System.Windows.Forms.Button();
            this.groupBoxDelete_TVD = new System.Windows.Forms.GroupBox();
            this.labelDeleteProduct_TVD = new System.Windows.Forms.Label();
            this.textBoxDeleteProduct_TVD = new System.Windows.Forms.TextBox();
            this.buttonDelete_TVD = new System.Windows.Forms.Button();
            this.groupBoxInfoMan_TVD = new System.Windows.Forms.GroupBox();
            this.labelNumber_TVD = new System.Windows.Forms.Label();
            this.textBoxNumber_TVD = new System.Windows.Forms.TextBox();
            this.labelDataProduct_TVD = new System.Windows.Forms.Label();
            this.labelFIO_TVD = new System.Windows.Forms.Label();
            this.textBoxDataProduct_TVD = new System.Windows.Forms.TextBox();
            this.textBoxFIO_TVD = new System.Windows.Forms.TextBox();
            this.groupBoxAdd_TVD = new System.Windows.Forms.GroupBox();
            this.labelInfo_TVD = new System.Windows.Forms.Label();
            this.labelCost_TVD = new System.Windows.Forms.Label();
            this.labelCount_TVD = new System.Windows.Forms.Label();
            this.labelName_TVD = new System.Windows.Forms.Label();
            this.buttonAdd_TVD = new System.Windows.Forms.Button();
            this.textBoxCount_TVD = new System.Windows.Forms.TextBox();
            this.textBoxInfo_TVD = new System.Windows.Forms.TextBox();
            this.textBoxCost_TVD = new System.Windows.Forms.TextBox();
            this.textBoxName_TVD = new System.Windows.Forms.TextBox();
            this.dataGridViewInPutData_TVD = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_TVD = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_TVD = new System.Windows.Forms.SaveFileDialog();
            this.toolTipInfo_TVD = new System.Windows.Forms.ToolTip(this.components);
            this.panelRight_TVD = new System.Windows.Forms.Panel();
            this.textBoxCountP_TVD = new System.Windows.Forms.TextBox();
            this.textBoxSum_TVD = new System.Windows.Forms.TextBox();
            this.textBoxAverage_TVD = new System.Windows.Forms.TextBox();
            this.textBoxMax_TVD = new System.Windows.Forms.TextBox();
            this.textBoxmin_TVD = new System.Windows.Forms.TextBox();
            this.buttonCalculateStats_TVD = new System.Windows.Forms.Button();
            this.labelNumberColumns_TVD = new System.Windows.Forms.Label();
            this.labelCountP_TVD = new System.Windows.Forms.Label();
            this.labelSum_TVD = new System.Windows.Forms.Label();
            this.labelaverage_TVD = new System.Windows.Forms.Label();
            this.labelMin_TVD = new System.Windows.Forms.Label();
            this.labelMax_TVD = new System.Windows.Forms.Label();
            this.chartStats_TVD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panelLeft_TVD.SuspendLayout();
            this.groupBoxStats_TVD.SuspendLayout();
            this.groupBoxDelete_TVD.SuspendLayout();
            this.groupBoxInfoMan_TVD.SuspendLayout();
            this.groupBoxAdd_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_TVD)).BeginInit();
            this.panelRight_TVD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_TVD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReturn_TVD);
            this.panel1.Controls.Add(this.buttonEditHeaders_TVD);
            this.panel1.Controls.Add(this.buttonHelp_TVD);
            this.panel1.Controls.Add(this.buttonSaveFile_TVD);
            this.panel1.Controls.Add(this.buttonOpenFile_TVD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 86);
            this.panel1.TabIndex = 0;
            // 
            // buttonReturn_TVD
            // 
            this.buttonReturn_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.arrow_left;
            this.buttonReturn_TVD.Location = new System.Drawing.Point(12, 11);
            this.buttonReturn_TVD.Name = "buttonReturn_TVD";
            this.buttonReturn_TVD.Size = new System.Drawing.Size(60, 60);
            this.buttonReturn_TVD.TabIndex = 6;
            this.toolTipInfo_TVD.SetToolTip(this.buttonReturn_TVD, "Вернуться в главное меню");
            this.buttonReturn_TVD.UseVisualStyleBackColor = true;
            this.buttonReturn_TVD.Click += new System.EventHandler(this.button7_Click);
            this.buttonReturn_TVD.MouseEnter += new System.EventHandler(this.buttonReturn_TVD_MouseEnter);
            // 
            // buttonEditHeaders_TVD
            // 
            this.buttonEditHeaders_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.application_edit;
            this.buttonEditHeaders_TVD.Location = new System.Drawing.Point(210, 11);
            this.buttonEditHeaders_TVD.Name = "buttonEditHeaders_TVD";
            this.buttonEditHeaders_TVD.Size = new System.Drawing.Size(60, 60);
            this.buttonEditHeaders_TVD.TabIndex = 4;
            this.toolTipInfo_TVD.SetToolTip(this.buttonEditHeaders_TVD, "При нажатии разблокирует редактирование базы, при повторном нажатии заблокирует.");
            this.buttonEditHeaders_TVD.UseVisualStyleBackColor = true;
            this.buttonEditHeaders_TVD.Click += new System.EventHandler(this.button5_Click);
            this.buttonEditHeaders_TVD.MouseEnter += new System.EventHandler(this.buttonEditHeaders_TVD_MouseEnter);
            // 
            // buttonHelp_TVD
            // 
            this.buttonHelp_TVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.help;
            this.buttonHelp_TVD.Location = new System.Drawing.Point(1034, 8);
            this.buttonHelp_TVD.Name = "buttonHelp_TVD";
            this.buttonHelp_TVD.Size = new System.Drawing.Size(60, 60);
            this.buttonHelp_TVD.TabIndex = 2;
            this.toolTipInfo_TVD.SetToolTip(this.buttonHelp_TVD, "Справка инструментальной панели");
            this.buttonHelp_TVD.UseVisualStyleBackColor = true;
            this.buttonHelp_TVD.Click += new System.EventHandler(this.button3_Click);
            this.buttonHelp_TVD.MouseEnter += new System.EventHandler(this.buttonHelp_TVD_MouseEnter);
            // 
            // buttonSaveFile_TVD
            // 
            this.buttonSaveFile_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.page_save;
            this.buttonSaveFile_TVD.Location = new System.Drawing.Point(144, 11);
            this.buttonSaveFile_TVD.Name = "buttonSaveFile_TVD";
            this.buttonSaveFile_TVD.Size = new System.Drawing.Size(60, 60);
            this.buttonSaveFile_TVD.TabIndex = 1;
            this.toolTipInfo_TVD.SetToolTip(this.buttonSaveFile_TVD, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSaveFile_TVD.UseVisualStyleBackColor = true;
            this.buttonSaveFile_TVD.Click += new System.EventHandler(this.button2_Click);
            this.buttonSaveFile_TVD.MouseEnter += new System.EventHandler(this.buttonSaveFile_TVD_MouseEnter);
            // 
            // buttonOpenFile_TVD
            // 
            this.buttonOpenFile_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.folder_page;
            this.buttonOpenFile_TVD.Location = new System.Drawing.Point(78, 11);
            this.buttonOpenFile_TVD.Name = "buttonOpenFile_TVD";
            this.buttonOpenFile_TVD.Size = new System.Drawing.Size(60, 60);
            this.buttonOpenFile_TVD.TabIndex = 0;
            this.toolTipInfo_TVD.SetToolTip(this.buttonOpenFile_TVD, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_TVD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_TVD.Click += new System.EventHandler(this.button1_Click);
            this.buttonOpenFile_TVD.MouseEnter += new System.EventHandler(this.buttonOpenFile_TVD_MouseEnter);
            // 
            // buttonStats_TVD
            // 
            this.buttonStats_TVD.Location = new System.Drawing.Point(503, 80);
            this.buttonStats_TVD.Name = "buttonStats_TVD";
            this.buttonStats_TVD.Size = new System.Drawing.Size(75, 23);
            this.buttonStats_TVD.TabIndex = 11;
            this.buttonStats_TVD.Text = "График";
            this.buttonStats_TVD.UseVisualStyleBackColor = true;
            this.buttonStats_TVD.Click += new System.EventHandler(this.buttonStats_TVD_Click);
            // 
            // labelSearch_TVD
            // 
            this.labelSearch_TVD.AutoSize = true;
            this.labelSearch_TVD.Location = new System.Drawing.Point(536, 20);
            this.labelSearch_TVD.Name = "labelSearch_TVD";
            this.labelSearch_TVD.Size = new System.Drawing.Size(42, 13);
            this.labelSearch_TVD.TabIndex = 8;
            this.labelSearch_TVD.Text = "Поиск ";
            // 
            // textBoxSearch_TVD
            // 
            this.textBoxSearch_TVD.Location = new System.Drawing.Point(478, 35);
            this.textBoxSearch_TVD.Name = "textBoxSearch_TVD";
            this.textBoxSearch_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch_TVD.TabIndex = 7;
            this.textBoxSearch_TVD.TextChanged += new System.EventHandler(this.textBoxSearch_TVD_TextChanged);
            // 
            // panelLeft_TVD
            // 
            this.panelLeft_TVD.Controls.Add(this.groupBoxStats_TVD);
            this.panelLeft_TVD.Controls.Add(this.groupBoxDelete_TVD);
            this.panelLeft_TVD.Controls.Add(this.groupBoxInfoMan_TVD);
            this.panelLeft_TVD.Controls.Add(this.groupBoxAdd_TVD);
            this.panelLeft_TVD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeft_TVD.Location = new System.Drawing.Point(0, 86);
            this.panelLeft_TVD.Name = "panelLeft_TVD";
            this.panelLeft_TVD.Size = new System.Drawing.Size(1106, 185);
            this.panelLeft_TVD.TabIndex = 1;
            // 
            // groupBoxStats_TVD
            // 
            this.groupBoxStats_TVD.Controls.Add(this.labelMax_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.labelMin_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.labelaverage_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.labelSum_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.labelCountP_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.labelNumberColumns_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.buttonCalculateStats_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.textBoxmin_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.textBoxMax_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.textBoxAverage_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.textBoxSum_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.textBoxCountP_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.textBoxSort_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.buttonSortNumberProduct_TVD);
            this.groupBoxStats_TVD.Controls.Add(this.buttonStats_TVD);
            this.groupBoxStats_TVD.Location = new System.Drawing.Point(516, 70);
            this.groupBoxStats_TVD.Name = "groupBoxStats_TVD";
            this.groupBoxStats_TVD.Size = new System.Drawing.Size(587, 115);
            this.groupBoxStats_TVD.TabIndex = 3;
            this.groupBoxStats_TVD.TabStop = false;
            this.groupBoxStats_TVD.Text = "Статистика";
            // 
            // textBoxSort_TVD
            // 
            this.textBoxSort_TVD.Location = new System.Drawing.Point(0, 59);
            this.textBoxSort_TVD.Name = "textBoxSort_TVD";
            this.textBoxSort_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxSort_TVD.TabIndex = 13;
            // 
            // buttonSortNumberProduct_TVD
            // 
            this.buttonSortNumberProduct_TVD.Location = new System.Drawing.Point(6, 17);
            this.buttonSortNumberProduct_TVD.Name = "buttonSortNumberProduct_TVD";
            this.buttonSortNumberProduct_TVD.Size = new System.Drawing.Size(75, 23);
            this.buttonSortNumberProduct_TVD.TabIndex = 12;
            this.buttonSortNumberProduct_TVD.Text = "Сортировка";
            this.buttonSortNumberProduct_TVD.UseVisualStyleBackColor = true;
            this.buttonSortNumberProduct_TVD.Click += new System.EventHandler(this.buttonSortNumberProduct_TVD_Click);
            // 
            // groupBoxDelete_TVD
            // 
            this.groupBoxDelete_TVD.Controls.Add(this.labelDeleteProduct_TVD);
            this.groupBoxDelete_TVD.Controls.Add(this.textBoxDeleteProduct_TVD);
            this.groupBoxDelete_TVD.Controls.Add(this.buttonDelete_TVD);
            this.groupBoxDelete_TVD.Location = new System.Drawing.Point(0, 115);
            this.groupBoxDelete_TVD.Name = "groupBoxDelete_TVD";
            this.groupBoxDelete_TVD.Size = new System.Drawing.Size(510, 69);
            this.groupBoxDelete_TVD.TabIndex = 1;
            this.groupBoxDelete_TVD.TabStop = false;
            this.groupBoxDelete_TVD.Text = "Удаление товара";
            // 
            // labelDeleteProduct_TVD
            // 
            this.labelDeleteProduct_TVD.AutoSize = true;
            this.labelDeleteProduct_TVD.Location = new System.Drawing.Point(6, 22);
            this.labelDeleteProduct_TVD.Name = "labelDeleteProduct_TVD";
            this.labelDeleteProduct_TVD.Size = new System.Drawing.Size(95, 13);
            this.labelDeleteProduct_TVD.TabIndex = 5;
            this.labelDeleteProduct_TVD.Text = "Название товара";
            // 
            // textBoxDeleteProduct_TVD
            // 
            this.textBoxDeleteProduct_TVD.Location = new System.Drawing.Point(7, 38);
            this.textBoxDeleteProduct_TVD.Name = "textBoxDeleteProduct_TVD";
            this.textBoxDeleteProduct_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeleteProduct_TVD.TabIndex = 4;
            // 
            // buttonDelete_TVD
            // 
            this.buttonDelete_TVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.cross;
            this.buttonDelete_TVD.Location = new System.Drawing.Point(113, 14);
            this.buttonDelete_TVD.Name = "buttonDelete_TVD";
            this.buttonDelete_TVD.Size = new System.Drawing.Size(50, 50);
            this.buttonDelete_TVD.TabIndex = 3;
            this.toolTipInfo_TVD.SetToolTip(this.buttonDelete_TVD, "Удаляет товар из базы.");
            this.buttonDelete_TVD.UseVisualStyleBackColor = true;
            this.buttonDelete_TVD.Click += new System.EventHandler(this.button4_Click);
            this.buttonDelete_TVD.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            // 
            // groupBoxInfoMan_TVD
            // 
            this.groupBoxInfoMan_TVD.Controls.Add(this.labelNumber_TVD);
            this.groupBoxInfoMan_TVD.Controls.Add(this.textBoxNumber_TVD);
            this.groupBoxInfoMan_TVD.Controls.Add(this.labelSearch_TVD);
            this.groupBoxInfoMan_TVD.Controls.Add(this.textBoxSearch_TVD);
            this.groupBoxInfoMan_TVD.Controls.Add(this.labelDataProduct_TVD);
            this.groupBoxInfoMan_TVD.Controls.Add(this.labelFIO_TVD);
            this.groupBoxInfoMan_TVD.Controls.Add(this.textBoxDataProduct_TVD);
            this.groupBoxInfoMan_TVD.Controls.Add(this.textBoxFIO_TVD);
            this.groupBoxInfoMan_TVD.Location = new System.Drawing.Point(516, 0);
            this.groupBoxInfoMan_TVD.Name = "groupBoxInfoMan_TVD";
            this.groupBoxInfoMan_TVD.Size = new System.Drawing.Size(596, 64);
            this.groupBoxInfoMan_TVD.TabIndex = 2;
            this.groupBoxInfoMan_TVD.TabStop = false;
            this.groupBoxInfoMan_TVD.Text = "Добавление поставщика";
            // 
            // labelNumber_TVD
            // 
            this.labelNumber_TVD.AutoSize = true;
            this.labelNumber_TVD.Location = new System.Drawing.Point(217, 19);
            this.labelNumber_TVD.Name = "labelNumber_TVD";
            this.labelNumber_TVD.Size = new System.Drawing.Size(106, 13);
            this.labelNumber_TVD.TabIndex = 6;
            this.labelNumber_TVD.Text = "Номер поставщика";
            // 
            // textBoxNumber_TVD
            // 
            this.textBoxNumber_TVD.Location = new System.Drawing.Point(217, 35);
            this.textBoxNumber_TVD.Name = "textBoxNumber_TVD";
            this.textBoxNumber_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber_TVD.TabIndex = 5;
            // 
            // labelDataProduct_TVD
            // 
            this.labelDataProduct_TVD.AutoSize = true;
            this.labelDataProduct_TVD.Location = new System.Drawing.Point(111, 20);
            this.labelDataProduct_TVD.Name = "labelDataProduct_TVD";
            this.labelDataProduct_TVD.Size = new System.Drawing.Size(82, 13);
            this.labelDataProduct_TVD.TabIndex = 4;
            this.labelDataProduct_TVD.Text = "Срок поставки";
            // 
            // labelFIO_TVD
            // 
            this.labelFIO_TVD.AutoSize = true;
            this.labelFIO_TVD.Location = new System.Drawing.Point(6, 20);
            this.labelFIO_TVD.Name = "labelFIO_TVD";
            this.labelFIO_TVD.Size = new System.Drawing.Size(99, 13);
            this.labelFIO_TVD.TabIndex = 3;
            this.labelFIO_TVD.Text = "ФИО поставщика";
            // 
            // textBoxDataProduct_TVD
            // 
            this.textBoxDataProduct_TVD.Location = new System.Drawing.Point(110, 36);
            this.textBoxDataProduct_TVD.Name = "textBoxDataProduct_TVD";
            this.textBoxDataProduct_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataProduct_TVD.TabIndex = 2;
            // 
            // textBoxFIO_TVD
            // 
            this.textBoxFIO_TVD.Location = new System.Drawing.Point(4, 36);
            this.textBoxFIO_TVD.Name = "textBoxFIO_TVD";
            this.textBoxFIO_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxFIO_TVD.TabIndex = 0;
            // 
            // groupBoxAdd_TVD
            // 
            this.groupBoxAdd_TVD.Controls.Add(this.labelInfo_TVD);
            this.groupBoxAdd_TVD.Controls.Add(this.labelCost_TVD);
            this.groupBoxAdd_TVD.Controls.Add(this.labelCount_TVD);
            this.groupBoxAdd_TVD.Controls.Add(this.labelName_TVD);
            this.groupBoxAdd_TVD.Controls.Add(this.buttonAdd_TVD);
            this.groupBoxAdd_TVD.Controls.Add(this.textBoxCount_TVD);
            this.groupBoxAdd_TVD.Controls.Add(this.textBoxInfo_TVD);
            this.groupBoxAdd_TVD.Controls.Add(this.textBoxCost_TVD);
            this.groupBoxAdd_TVD.Controls.Add(this.textBoxName_TVD);
            this.groupBoxAdd_TVD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAdd_TVD.Name = "groupBoxAdd_TVD";
            this.groupBoxAdd_TVD.Size = new System.Drawing.Size(510, 115);
            this.groupBoxAdd_TVD.TabIndex = 0;
            this.groupBoxAdd_TVD.TabStop = false;
            this.groupBoxAdd_TVD.Text = "Добавление товара на склад";
            // 
            // labelInfo_TVD
            // 
            this.labelInfo_TVD.AutoSize = true;
            this.labelInfo_TVD.Location = new System.Drawing.Point(346, 20);
            this.labelInfo_TVD.Name = "labelInfo_TVD";
            this.labelInfo_TVD.Size = new System.Drawing.Size(165, 13);
            this.labelInfo_TVD.TabIndex = 8;
            this.labelInfo_TVD.Text = "Примечание - описание товара";
            // 
            // labelCost_TVD
            // 
            this.labelCost_TVD.AutoSize = true;
            this.labelCost_TVD.Location = new System.Drawing.Point(222, 20);
            this.labelCost_TVD.Name = "labelCost_TVD";
            this.labelCost_TVD.Size = new System.Drawing.Size(118, 13);
            this.labelCost_TVD.TabIndex = 7;
            this.labelCost_TVD.Text = "Стоимость ед. товара";
            // 
            // labelCount_TVD
            // 
            this.labelCount_TVD.AutoSize = true;
            this.labelCount_TVD.Location = new System.Drawing.Point(119, 20);
            this.labelCount_TVD.Name = "labelCount_TVD";
            this.labelCount_TVD.Size = new System.Drawing.Size(104, 13);
            this.labelCount_TVD.TabIndex = 6;
            this.labelCount_TVD.Text = "Количество товара";
            // 
            // labelName_TVD
            // 
            this.labelName_TVD.AutoSize = true;
            this.labelName_TVD.Location = new System.Drawing.Point(10, 20);
            this.labelName_TVD.Name = "labelName_TVD";
            this.labelName_TVD.Size = new System.Drawing.Size(95, 13);
            this.labelName_TVD.TabIndex = 5;
            this.labelName_TVD.Text = "Название товара";
            // 
            // buttonAdd_TVD
            // 
            this.buttonAdd_TVD.Image = global::Tyuiu.TarasovVD.Sprint7.Project.V5.Properties.Resources.add;
            this.buttonAdd_TVD.Location = new System.Drawing.Point(13, 59);
            this.buttonAdd_TVD.Name = "buttonAdd_TVD";
            this.buttonAdd_TVD.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd_TVD.TabIndex = 4;
            this.toolTipInfo_TVD.SetToolTip(this.buttonAdd_TVD, "Добавляет товар в базу.");
            this.buttonAdd_TVD.UseVisualStyleBackColor = true;
            this.buttonAdd_TVD.Click += new System.EventHandler(this.buttonAdd_TVD_Click);
            this.buttonAdd_TVD.MouseEnter += new System.EventHandler(this.buttonAdd_TVD_MouseEnter);
            // 
            // textBoxCount_TVD
            // 
            this.textBoxCount_TVD.Location = new System.Drawing.Point(119, 36);
            this.textBoxCount_TVD.Name = "textBoxCount_TVD";
            this.textBoxCount_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount_TVD.TabIndex = 3;
            // 
            // textBoxInfo_TVD
            // 
            this.textBoxInfo_TVD.Location = new System.Drawing.Point(346, 36);
            this.textBoxInfo_TVD.Name = "textBoxInfo_TVD";
            this.textBoxInfo_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxInfo_TVD.TabIndex = 2;
            // 
            // textBoxCost_TVD
            // 
            this.textBoxCost_TVD.Location = new System.Drawing.Point(225, 36);
            this.textBoxCost_TVD.Name = "textBoxCost_TVD";
            this.textBoxCost_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost_TVD.TabIndex = 1;
            // 
            // textBoxName_TVD
            // 
            this.textBoxName_TVD.Location = new System.Drawing.Point(13, 36);
            this.textBoxName_TVD.Name = "textBoxName_TVD";
            this.textBoxName_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxName_TVD.TabIndex = 0;
            // 
            // dataGridViewInPutData_TVD
            // 
            this.dataGridViewInPutData_TVD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInPutData_TVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_TVD.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInPutData_TVD.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewInPutData_TVD.Name = "dataGridViewInPutData_TVD";
            this.dataGridViewInPutData_TVD.ReadOnly = true;
            this.dataGridViewInPutData_TVD.Size = new System.Drawing.Size(511, 373);
            this.dataGridViewInPutData_TVD.TabIndex = 0;
            // 
            // openFileDialogTask_TVD
            // 
            this.openFileDialogTask_TVD.FileName = "openFileDialog1";
            // 
            // toolTipInfo_TVD
            // 
            this.toolTipInfo_TVD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // panelRight_TVD
            // 
            this.panelRight_TVD.Controls.Add(this.chartStats_TVD);
            this.panelRight_TVD.Controls.Add(this.dataGridViewInPutData_TVD);
            this.panelRight_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_TVD.Location = new System.Drawing.Point(0, 271);
            this.panelRight_TVD.Name = "panelRight_TVD";
            this.panelRight_TVD.Size = new System.Drawing.Size(1106, 373);
            this.panelRight_TVD.TabIndex = 3;
            // 
            // textBoxCountP_TVD
            // 
            this.textBoxCountP_TVD.Location = new System.Drawing.Point(182, 20);
            this.textBoxCountP_TVD.Name = "textBoxCountP_TVD";
            this.textBoxCountP_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountP_TVD.TabIndex = 14;
            // 
            // textBoxSum_TVD
            // 
            this.textBoxSum_TVD.Location = new System.Drawing.Point(288, 21);
            this.textBoxSum_TVD.Name = "textBoxSum_TVD";
            this.textBoxSum_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum_TVD.TabIndex = 15;
            // 
            // textBoxAverage_TVD
            // 
            this.textBoxAverage_TVD.Location = new System.Drawing.Point(397, 20);
            this.textBoxAverage_TVD.Name = "textBoxAverage_TVD";
            this.textBoxAverage_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverage_TVD.TabIndex = 16;
            // 
            // textBoxMax_TVD
            // 
            this.textBoxMax_TVD.Location = new System.Drawing.Point(288, 59);
            this.textBoxMax_TVD.Name = "textBoxMax_TVD";
            this.textBoxMax_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax_TVD.TabIndex = 17;
            // 
            // textBoxmin_TVD
            // 
            this.textBoxmin_TVD.Location = new System.Drawing.Point(182, 59);
            this.textBoxmin_TVD.Name = "textBoxmin_TVD";
            this.textBoxmin_TVD.Size = new System.Drawing.Size(100, 20);
            this.textBoxmin_TVD.TabIndex = 18;
            // 
            // buttonCalculateStats_TVD
            // 
            this.buttonCalculateStats_TVD.Location = new System.Drawing.Point(503, 19);
            this.buttonCalculateStats_TVD.Name = "buttonCalculateStats_TVD";
            this.buttonCalculateStats_TVD.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateStats_TVD.TabIndex = 19;
            this.buttonCalculateStats_TVD.Text = "Статистика";
            this.buttonCalculateStats_TVD.UseVisualStyleBackColor = true;
            this.buttonCalculateStats_TVD.Click += new System.EventHandler(this.buttonCalculateStats_Click);
            // 
            // labelNumberColumns_TVD
            // 
            this.labelNumberColumns_TVD.AutoSize = true;
            this.labelNumberColumns_TVD.Location = new System.Drawing.Point(0, 45);
            this.labelNumberColumns_TVD.Name = "labelNumberColumns_TVD";
            this.labelNumberColumns_TVD.Size = new System.Drawing.Size(128, 13);
            this.labelNumberColumns_TVD.TabIndex = 20;
            this.labelNumberColumns_TVD.Text = "Введите номер столбца";
            // 
            // labelCountP_TVD
            // 
            this.labelCountP_TVD.AutoSize = true;
            this.labelCountP_TVD.Location = new System.Drawing.Point(179, 8);
            this.labelCountP_TVD.Name = "labelCountP_TVD";
            this.labelCountP_TVD.Size = new System.Drawing.Size(66, 13);
            this.labelCountP_TVD.TabIndex = 21;
            this.labelCountP_TVD.Text = "Количество";
            // 
            // labelSum_TVD
            // 
            this.labelSum_TVD.AutoSize = true;
            this.labelSum_TVD.Location = new System.Drawing.Point(288, 8);
            this.labelSum_TVD.Name = "labelSum_TVD";
            this.labelSum_TVD.Size = new System.Drawing.Size(78, 13);
            this.labelSum_TVD.TabIndex = 22;
            this.labelSum_TVD.Text = "Общее кол-во";
            // 
            // labelaverage_TVD
            // 
            this.labelaverage_TVD.AutoSize = true;
            this.labelaverage_TVD.Location = new System.Drawing.Point(394, 9);
            this.labelaverage_TVD.Name = "labelaverage_TVD";
            this.labelaverage_TVD.Size = new System.Drawing.Size(86, 13);
            this.labelaverage_TVD.TabIndex = 23;
            this.labelaverage_TVD.Text = "Среднее кол-во";
            // 
            // labelMin_TVD
            // 
            this.labelMin_TVD.AutoSize = true;
            this.labelMin_TVD.Location = new System.Drawing.Point(179, 45);
            this.labelMin_TVD.Name = "labelMin_TVD";
            this.labelMin_TVD.Size = new System.Drawing.Size(64, 13);
            this.labelMin_TVD.TabIndex = 24;
            this.labelMin_TVD.Text = "Мин кол-во";
            // 
            // labelMax_TVD
            // 
            this.labelMax_TVD.AutoSize = true;
            this.labelMax_TVD.Location = new System.Drawing.Point(288, 45);
            this.labelMax_TVD.Name = "labelMax_TVD";
            this.labelMax_TVD.Size = new System.Drawing.Size(70, 13);
            this.labelMax_TVD.TabIndex = 25;
            this.labelMax_TVD.Text = "Макс-кол-во";
            // 
            // chartStats_TVD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStats_TVD.ChartAreas.Add(chartArea1);
            this.chartStats_TVD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStats_TVD.Legends.Add(legend1);
            this.chartStats_TVD.Location = new System.Drawing.Point(511, 0);
            this.chartStats_TVD.Name = "chartStats_TVD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStats_TVD.Series.Add(series1);
            this.chartStats_TVD.Size = new System.Drawing.Size(595, 373);
            this.chartStats_TVD.TabIndex = 1;
            this.chartStats_TVD.Text = "chart1";
            // 
            // FormInstrument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 644);
            this.Controls.Add(this.panelRight_TVD);
            this.Controls.Add(this.panelLeft_TVD);
            this.Controls.Add(this.panel1);
            this.Name = "FormInstrument";
            this.Text = "Инструментальная панель";
            this.panel1.ResumeLayout(false);
            this.panelLeft_TVD.ResumeLayout(false);
            this.groupBoxStats_TVD.ResumeLayout(false);
            this.groupBoxStats_TVD.PerformLayout();
            this.groupBoxDelete_TVD.ResumeLayout(false);
            this.groupBoxDelete_TVD.PerformLayout();
            this.groupBoxInfoMan_TVD.ResumeLayout(false);
            this.groupBoxInfoMan_TVD.PerformLayout();
            this.groupBoxAdd_TVD.ResumeLayout(false);
            this.groupBoxAdd_TVD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_TVD)).EndInit();
            this.panelRight_TVD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_TVD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReturn_TVD;
        private System.Windows.Forms.Button buttonEditHeaders_TVD;
        private System.Windows.Forms.Button buttonDelete_TVD;
        private System.Windows.Forms.Button buttonHelp_TVD;
        private System.Windows.Forms.Button buttonSaveFile_TVD;
        private System.Windows.Forms.Button buttonOpenFile_TVD;
        private System.Windows.Forms.Panel panelLeft_TVD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_TVD;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_TVD;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_TVD;
        private System.Windows.Forms.ToolTip toolTipInfo_TVD;
        private System.Windows.Forms.Panel panelRight_TVD;
        private System.Windows.Forms.GroupBox groupBoxAdd_TVD;
        private System.Windows.Forms.Label labelInfo_TVD;
        private System.Windows.Forms.Label labelCost_TVD;
        private System.Windows.Forms.Label labelCount_TVD;
        private System.Windows.Forms.Label labelName_TVD;
        private System.Windows.Forms.Button buttonAdd_TVD;
        private System.Windows.Forms.TextBox textBoxCount_TVD;
        private System.Windows.Forms.TextBox textBoxInfo_TVD;
        private System.Windows.Forms.TextBox textBoxCost_TVD;
        private System.Windows.Forms.TextBox textBoxName_TVD;
        private System.Windows.Forms.GroupBox groupBoxDelete_TVD;
        private System.Windows.Forms.Label labelDeleteProduct_TVD;
        private System.Windows.Forms.TextBox textBoxDeleteProduct_TVD;
        private System.Windows.Forms.GroupBox groupBoxInfoMan_TVD;
        private System.Windows.Forms.TextBox textBoxFIO_TVD;
        private System.Windows.Forms.TextBox textBoxDataProduct_TVD;
        private System.Windows.Forms.Label labelDataProduct_TVD;
        private System.Windows.Forms.Label labelFIO_TVD;
        private System.Windows.Forms.TextBox textBoxSearch_TVD;
        private System.Windows.Forms.Label labelSearch_TVD;
        private System.Windows.Forms.Button buttonStats_TVD;
        private System.Windows.Forms.Label labelNumber_TVD;
        private System.Windows.Forms.TextBox textBoxNumber_TVD;
        private System.Windows.Forms.GroupBox groupBoxStats_TVD;
        private System.Windows.Forms.Button buttonSortNumberProduct_TVD;
        private System.Windows.Forms.TextBox textBoxSort_TVD;
        private System.Windows.Forms.TextBox textBoxmin_TVD;
        private System.Windows.Forms.TextBox textBoxMax_TVD;
        private System.Windows.Forms.TextBox textBoxAverage_TVD;
        private System.Windows.Forms.TextBox textBoxSum_TVD;
        private System.Windows.Forms.TextBox textBoxCountP_TVD;
        private System.Windows.Forms.Button buttonCalculateStats_TVD;
        private System.Windows.Forms.Label labelMax_TVD;
        private System.Windows.Forms.Label labelMin_TVD;
        private System.Windows.Forms.Label labelaverage_TVD;
        private System.Windows.Forms.Label labelSum_TVD;
        private System.Windows.Forms.Label labelCountP_TVD;
        private System.Windows.Forms.Label labelNumberColumns_TVD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_TVD;
    }
}