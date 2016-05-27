namespace Hotel_Administrator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заселитьГостейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выселитьГостейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиГостейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продлитьПребываниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьКвитанцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиСвободныйНомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelInformPanel = new System.Windows.Forms.GroupBox();
            this.hotelInformBusyCount = new System.Windows.Forms.Label();
            this.hotelInformEmptyCount = new System.Windows.Forms.Label();
            this.hotelInformAllCount = new System.Windows.Forms.Label();
            this.hotelInformBusy = new System.Windows.Forms.Label();
            this.hotelInformEmpty = new System.Windows.Forms.Label();
            this.hotelInformAll = new System.Windows.Forms.Label();
            this.guestsInformPanel = new System.Windows.Forms.GroupBox();
            this.guestsInformLeaveCount = new System.Windows.Forms.Label();
            this.guestsInformAllCount = new System.Windows.Forms.Label();
            this.guestsInformLeave = new System.Windows.Forms.Label();
            this.guestsInformAll = new System.Windows.Forms.Label();
            this.hotelPanelTitle = new System.Windows.Forms.Label();
            this.hotelPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.GroupBox();
            this.findGuestsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showInvoicesButton = new System.Windows.Forms.Button();
            this.unsettleGuestsButton = new System.Windows.Forms.Button();
            this.settleGuestsButton = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.GroupBox();
            this.changeLeaveDateButton = new System.Windows.Forms.Button();
            this.todayLabel = new System.Windows.Forms.Label();
            this.todayPanel = new System.Windows.Forms.Panel();
            this.staticsPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.hotelInformPanel.SuspendLayout();
            this.guestsInformPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.todayPanel.SuspendLayout();
            this.staticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.GuestsToolStripMenuItem,
            this.HotelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveChangesToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SaveChangesToolStripMenuItem
            // 
            this.SaveChangesToolStripMenuItem.Name = "SaveChangesToolStripMenuItem";
            this.SaveChangesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SaveChangesToolStripMenuItem.Text = "Сохранить изменения";
            this.SaveChangesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveChangesToolStripMenuItem.Click += new System.EventHandler(this.SaveChangesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GuestsToolStripMenuItem
            // 
            this.GuestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заселитьГостейToolStripMenuItem,
            this.выселитьГостейToolStripMenuItem,
            this.найтиГостейToolStripMenuItem,
            this.продлитьПребываниеToolStripMenuItem,
            this.посмотретьКвитанцииToolStripMenuItem});
            this.GuestsToolStripMenuItem.Name = "GuestsToolStripMenuItem";
            this.GuestsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.GuestsToolStripMenuItem.Text = "Гости";
            // 
            // заселитьГостейToolStripMenuItem
            // 
            this.заселитьГостейToolStripMenuItem.Name = "заселитьГостейToolStripMenuItem";
            this.заселитьГостейToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.заселитьГостейToolStripMenuItem.Text = "Заселить гостей";
            this.заселитьГостейToolStripMenuItem.Click += new System.EventHandler(this.addGuests_Click);
            // 
            // выселитьГостейToolStripMenuItem
            // 
            this.выселитьГостейToolStripMenuItem.Name = "выселитьГостейToolStripMenuItem";
            this.выселитьГостейToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.выселитьГостейToolStripMenuItem.Text = "Выселить гостей";
            this.выселитьГостейToolStripMenuItem.Click += new System.EventHandler(this.deleteGuests_Click);
            // 
            // найтиГостейToolStripMenuItem
            // 
            this.найтиГостейToolStripMenuItem.Name = "найтиГостейToolStripMenuItem";
            this.найтиГостейToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.найтиГостейToolStripMenuItem.Text = "Найти гостей";
            this.найтиГостейToolStripMenuItem.Click += new System.EventHandler(this.findGuests_Click);
            // 
            // продлитьПребываниеToolStripMenuItem
            // 
            this.продлитьПребываниеToolStripMenuItem.Name = "продлитьПребываниеToolStripMenuItem";
            this.продлитьПребываниеToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.продлитьПребываниеToolStripMenuItem.Text = "Изменить дату отъезда";
            this.продлитьПребываниеToolStripMenuItem.Click += new System.EventHandler(this.changeLeaveDate_Click);
            // 
            // посмотретьКвитанцииToolStripMenuItem
            // 
            this.посмотретьКвитанцииToolStripMenuItem.Name = "посмотретьКвитанцииToolStripMenuItem";
            this.посмотретьКвитанцииToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.посмотретьКвитанцииToolStripMenuItem.Text = "Посмотреть квитанции";
            this.посмотретьКвитанцииToolStripMenuItem.Click += new System.EventHandler(this.viewInvoices_Click);
            // 
            // HotelToolStripMenuItem
            // 
            this.HotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтиСвободныйНомерToolStripMenuItem,
            this.AddRoomsToolStripMenuItem,
            this.DeleteRoomToolStripMenuItem,
            this.AddFloorToolStripMenuItem,
            this.DeleteFloorToolStripMenuItem});
            this.HotelToolStripMenuItem.Name = "HotelToolStripMenuItem";
            this.HotelToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.HotelToolStripMenuItem.Text = "Гостинница";
            // 
            // найтиСвободныйНомерToolStripMenuItem
            // 
            this.найтиСвободныйНомерToolStripMenuItem.Name = "найтиСвободныйНомерToolStripMenuItem";
            this.найтиСвободныйНомерToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.найтиСвободныйНомерToolStripMenuItem.Text = "Найти свободный номер";
            this.найтиСвободныйНомерToolStripMenuItem.Click += new System.EventHandler(this.findEmptyRooms_Click);
            // 
            // AddRoomsToolStripMenuItem
            // 
            this.AddRoomsToolStripMenuItem.Name = "AddRoomsToolStripMenuItem";
            this.AddRoomsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.AddRoomsToolStripMenuItem.Text = "Добавить этаж";
            this.AddRoomsToolStripMenuItem.Click += new System.EventHandler(this.addFloor_Click);
            // 
            // DeleteRoomToolStripMenuItem
            // 
            this.DeleteRoomToolStripMenuItem.Name = "DeleteRoomToolStripMenuItem";
            this.DeleteRoomToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.DeleteRoomToolStripMenuItem.Text = "Удалить верхний этаж";
            this.DeleteRoomToolStripMenuItem.Click += new System.EventHandler(this.deleteFloor_Click);
            // 
            // AddFloorToolStripMenuItem
            // 
            this.AddFloorToolStripMenuItem.Name = "AddFloorToolStripMenuItem";
            this.AddFloorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.AddFloorToolStripMenuItem.Text = "Добавить номер(а)";
            this.AddFloorToolStripMenuItem.Click += new System.EventHandler(this.addRooms_Click);
            // 
            // DeleteFloorToolStripMenuItem
            // 
            this.DeleteFloorToolStripMenuItem.Name = "DeleteFloorToolStripMenuItem";
            this.DeleteFloorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.DeleteFloorToolStripMenuItem.Text = "Удалить номер";
            this.DeleteFloorToolStripMenuItem.Click += new System.EventHandler(this.deleteRoom_Click);
            // 
            // hotelInformPanel
            // 
            this.hotelInformPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hotelInformPanel.Controls.Add(this.hotelInformBusyCount);
            this.hotelInformPanel.Controls.Add(this.hotelInformEmptyCount);
            this.hotelInformPanel.Controls.Add(this.hotelInformAllCount);
            this.hotelInformPanel.Controls.Add(this.hotelInformBusy);
            this.hotelInformPanel.Controls.Add(this.hotelInformEmpty);
            this.hotelInformPanel.Controls.Add(this.hotelInformAll);
            this.hotelInformPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotelInformPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelInformPanel.Location = new System.Drawing.Point(726, 99);
            this.hotelInformPanel.Name = "hotelInformPanel";
            this.hotelInformPanel.Size = new System.Drawing.Size(238, 146);
            this.hotelInformPanel.TabIndex = 21;
            this.hotelInformPanel.TabStop = false;
            this.hotelInformPanel.Text = "Информация о гостиннице";
            // 
            // hotelInformBusyCount
            // 
            this.hotelInformBusyCount.AutoSize = true;
            this.hotelInformBusyCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "BusyRoomNumber", true));
            this.hotelInformBusyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelInformBusyCount.Location = new System.Drawing.Point(202, 109);
            this.hotelInformBusyCount.Name = "hotelInformBusyCount";
            this.hotelInformBusyCount.Size = new System.Drawing.Size(52, 17);
            this.hotelInformBusyCount.TabIndex = 27;
            this.hotelInformBusyCount.Text = "label3";
            // 
            // hotelInformEmptyCount
            // 
            this.hotelInformEmptyCount.AutoSize = true;
            this.hotelInformEmptyCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "EmptyRoomNumber", true));
            this.hotelInformEmptyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelInformEmptyCount.Location = new System.Drawing.Point(202, 74);
            this.hotelInformEmptyCount.Name = "hotelInformEmptyCount";
            this.hotelInformEmptyCount.Size = new System.Drawing.Size(52, 17);
            this.hotelInformEmptyCount.TabIndex = 26;
            this.hotelInformEmptyCount.Text = "label2";
            // 
            // hotelInformAllCount
            // 
            this.hotelInformAllCount.AutoSize = true;
            this.hotelInformAllCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "RoomNumber", true));
            this.hotelInformAllCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelInformAllCount.Location = new System.Drawing.Point(202, 39);
            this.hotelInformAllCount.Name = "hotelInformAllCount";
            this.hotelInformAllCount.Size = new System.Drawing.Size(52, 17);
            this.hotelInformAllCount.TabIndex = 25;
            this.hotelInformAllCount.Text = "label1";
            // 
            // hotelInformBusy
            // 
            this.hotelInformBusy.AutoSize = true;
            this.hotelInformBusy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelInformBusy.Location = new System.Drawing.Point(8, 109);
            this.hotelInformBusy.Name = "hotelInformBusy";
            this.hotelInformBusy.Size = new System.Drawing.Size(120, 17);
            this.hotelInformBusy.TabIndex = 24;
            this.hotelInformBusy.Text = "Занято номеров:";
            // 
            // hotelInformEmpty
            // 
            this.hotelInformEmpty.AutoSize = true;
            this.hotelInformEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelInformEmpty.Location = new System.Drawing.Point(8, 74);
            this.hotelInformEmpty.Name = "hotelInformEmpty";
            this.hotelInformEmpty.Size = new System.Drawing.Size(136, 17);
            this.hotelInformEmpty.TabIndex = 23;
            this.hotelInformEmpty.Text = "Свободно номеров:";
            // 
            // hotelInformAll
            // 
            this.hotelInformAll.AutoSize = true;
            this.hotelInformAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelInformAll.Location = new System.Drawing.Point(8, 39);
            this.hotelInformAll.Name = "hotelInformAll";
            this.hotelInformAll.Size = new System.Drawing.Size(109, 17);
            this.hotelInformAll.TabIndex = 22;
            this.hotelInformAll.Text = "Всего номеров:";
            // 
            // guestsInformPanel
            // 
            this.guestsInformPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guestsInformPanel.Controls.Add(this.guestsInformLeaveCount);
            this.guestsInformPanel.Controls.Add(this.guestsInformAllCount);
            this.guestsInformPanel.Controls.Add(this.guestsInformLeave);
            this.guestsInformPanel.Controls.Add(this.guestsInformAll);
            this.guestsInformPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestsInformPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestsInformPanel.Location = new System.Drawing.Point(726, 262);
            this.guestsInformPanel.Name = "guestsInformPanel";
            this.guestsInformPanel.Size = new System.Drawing.Size(238, 108);
            this.guestsInformPanel.TabIndex = 22;
            this.guestsInformPanel.TabStop = false;
            this.guestsInformPanel.Text = "Информация о гостях";
            // 
            // guestsInformLeaveCount
            // 
            this.guestsInformLeaveCount.AutoSize = true;
            this.guestsInformLeaveCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestsBindingSource, "TodayLeaveNumber", true));
            this.guestsInformLeaveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestsInformLeaveCount.Location = new System.Drawing.Point(202, 74);
            this.guestsInformLeaveCount.Name = "guestsInformLeaveCount";
            this.guestsInformLeaveCount.Size = new System.Drawing.Size(52, 17);
            this.guestsInformLeaveCount.TabIndex = 26;
            this.guestsInformLeaveCount.Text = "label2";
            // 
            // guestsInformAllCount
            // 
            this.guestsInformAllCount.AutoSize = true;
            this.guestsInformAllCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.guestsBindingSource, "GuestNumber", true));
            this.guestsInformAllCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestsInformAllCount.Location = new System.Drawing.Point(202, 39);
            this.guestsInformAllCount.Name = "guestsInformAllCount";
            this.guestsInformAllCount.Size = new System.Drawing.Size(52, 17);
            this.guestsInformAllCount.TabIndex = 25;
            this.guestsInformAllCount.Text = "label1";
            // 
            // guestsInformLeave
            // 
            this.guestsInformLeave.AutoSize = true;
            this.guestsInformLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestsInformLeave.Location = new System.Drawing.Point(8, 74);
            this.guestsInformLeave.Name = "guestsInformLeave";
            this.guestsInformLeave.Size = new System.Drawing.Size(136, 17);
            this.guestsInformLeave.TabIndex = 23;
            this.guestsInformLeave.Text = "Выезжают сегодня:";
            // 
            // guestsInformAll
            // 
            this.guestsInformAll.AutoSize = true;
            this.guestsInformAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestsInformAll.Location = new System.Drawing.Point(8, 39);
            this.guestsInformAll.Name = "guestsInformAll";
            this.guestsInformAll.Size = new System.Drawing.Size(96, 17);
            this.guestsInformAll.TabIndex = 22;
            this.guestsInformAll.Text = "Всего гостей:";
            // 
            // hotelPanelTitle
            // 
            this.hotelPanelTitle.AutoSize = true;
            this.hotelPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelPanelTitle.Location = new System.Drawing.Point(16, 33);
            this.hotelPanelTitle.Name = "hotelPanelTitle";
            this.hotelPanelTitle.Size = new System.Drawing.Size(160, 25);
            this.hotelPanelTitle.TabIndex = 10;
            this.hotelPanelTitle.Text = "Схема номеров";
            this.hotelPanelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hotelPanel
            // 
            this.hotelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotelPanel.AutoScroll = true;
            this.hotelPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hotelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hotelPanel.Location = new System.Drawing.Point(12, 47);
            this.hotelPanel.Name = "hotelPanel";
            this.hotelPanel.Size = new System.Drawing.Size(697, 494);
            this.hotelPanel.TabIndex = 19;
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.Controls.Add(this.findGuestsButton);
            this.searchPanel.Controls.Add(this.button1);
            this.searchPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPanel.Location = new System.Drawing.Point(726, 387);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(238, 154);
            this.searchPanel.TabIndex = 23;
            this.searchPanel.TabStop = false;
            this.searchPanel.Text = "Поиск";
            // 
            // findGuestsButton
            // 
            this.findGuestsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.findGuestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.findGuestsButton.Location = new System.Drawing.Point(31, 98);
            this.findGuestsButton.Name = "findGuestsButton";
            this.findGuestsButton.Size = new System.Drawing.Size(180, 38);
            this.findGuestsButton.TabIndex = 2;
            this.findGuestsButton.Text = "Найти гостей";
            this.findGuestsButton.UseVisualStyleBackColor = false;
            this.findGuestsButton.Click += new System.EventHandler(this.findGuests_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(31, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 48);
            this.button1.TabIndex = 25;
            this.button1.Text = "Найти свободные номера";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.findEmptyRooms_Click);
            // 
            // showInvoicesButton
            // 
            this.showInvoicesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.showInvoicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.showInvoicesButton.Location = new System.Drawing.Point(568, 35);
            this.showInvoicesButton.Name = "showInvoicesButton";
            this.showInvoicesButton.Size = new System.Drawing.Size(119, 30);
            this.showInvoicesButton.TabIndex = 3;
            this.showInvoicesButton.Text = "Квитанции";
            this.showInvoicesButton.UseVisualStyleBackColor = false;
            this.showInvoicesButton.Click += new System.EventHandler(this.viewInvoices_Click);
            // 
            // unsettleGuestsButton
            // 
            this.unsettleGuestsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.unsettleGuestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.unsettleGuestsButton.Location = new System.Drawing.Point(178, 35);
            this.unsettleGuestsButton.Name = "unsettleGuestsButton";
            this.unsettleGuestsButton.Size = new System.Drawing.Size(152, 30);
            this.unsettleGuestsButton.TabIndex = 1;
            this.unsettleGuestsButton.Text = "Выселить гостей";
            this.unsettleGuestsButton.UseVisualStyleBackColor = false;
            this.unsettleGuestsButton.Click += new System.EventHandler(this.deleteGuests_Click);
            // 
            // settleGuestsButton
            // 
            this.settleGuestsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.settleGuestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.settleGuestsButton.Location = new System.Drawing.Point(9, 35);
            this.settleGuestsButton.Name = "settleGuestsButton";
            this.settleGuestsButton.Size = new System.Drawing.Size(146, 30);
            this.settleGuestsButton.TabIndex = 0;
            this.settleGuestsButton.Text = "Заселить гостей";
            this.settleGuestsButton.UseVisualStyleBackColor = false;
            this.settleGuestsButton.Click += new System.EventHandler(this.addGuests_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.showInvoicesButton);
            this.editPanel.Controls.Add(this.changeLeaveDateButton);
            this.editPanel.Controls.Add(this.settleGuestsButton);
            this.editPanel.Controls.Add(this.unsettleGuestsButton);
            this.editPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPanel.Location = new System.Drawing.Point(12, 553);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(697, 84);
            this.editPanel.TabIndex = 24;
            this.editPanel.TabStop = false;
            this.editPanel.Text = "Управление";
            // 
            // changeLeaveDateButton
            // 
            this.changeLeaveDateButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.changeLeaveDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.changeLeaveDateButton.Location = new System.Drawing.Point(355, 35);
            this.changeLeaveDateButton.Name = "changeLeaveDateButton";
            this.changeLeaveDateButton.Size = new System.Drawing.Size(190, 30);
            this.changeLeaveDateButton.TabIndex = 2;
            this.changeLeaveDateButton.Text = "Изменить дату отъезда";
            this.changeLeaveDateButton.UseVisualStyleBackColor = false;
            this.changeLeaveDateButton.Click += new System.EventHandler(this.changeLeaveDate_Click);
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.todayLabel.Location = new System.Drawing.Point(27, 6);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(182, 24);
            this.todayLabel.TabIndex = 25;
            this.todayLabel.Text = "Сегодня 14.05.2016";
            // 
            // todayPanel
            // 
            this.todayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.todayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todayPanel.Controls.Add(this.todayLabel);
            this.todayPanel.Location = new System.Drawing.Point(726, 47);
            this.todayPanel.Name = "todayPanel";
            this.todayPanel.Size = new System.Drawing.Size(238, 37);
            this.todayPanel.TabIndex = 26;
            // 
            // staticsPanel
            // 
            this.staticsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.staticsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staticsPanel.Controls.Add(this.button2);
            this.staticsPanel.Location = new System.Drawing.Point(726, 562);
            this.staticsPanel.Name = "staticsPanel";
            this.staticsPanel.Size = new System.Drawing.Size(238, 75);
            this.staticsPanel.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.Location = new System.Drawing.Point(29, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Статистика";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataSource = typeof(Hotel_Administrator.Guests);
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(Hotel_Administrator.Hotel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 649);
            this.Controls.Add(this.staticsPanel);
            this.Controls.Add(this.todayPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.hotelPanelTitle);
            this.Controls.Add(this.guestsInformPanel);
            this.Controls.Add(this.hotelInformPanel);
            this.Controls.Add(this.hotelPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(10000, 688);
            this.MinimumSize = new System.Drawing.Size(992, 688);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор гостиницы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.hotelInformPanel.ResumeLayout(false);
            this.hotelInformPanel.PerformLayout();
            this.guestsInformPanel.ResumeLayout(false);
            this.guestsInformPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.editPanel.ResumeLayout(false);
            this.todayPanel.ResumeLayout(false);
            this.todayPanel.PerformLayout();
            this.staticsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFloorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteFloorToolStripMenuItem;
        private System.Windows.Forms.GroupBox hotelInformPanel;
        private System.Windows.Forms.Label hotelInformAll;
        private System.Windows.Forms.Label hotelInformBusy;
        private System.Windows.Forms.Label hotelInformEmpty;
        private System.Windows.Forms.Label hotelInformBusyCount;
        private System.Windows.Forms.Label hotelInformEmptyCount;
        private System.Windows.Forms.Label hotelInformAllCount;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private System.Windows.Forms.GroupBox guestsInformPanel;
        private System.Windows.Forms.Label guestsInformLeaveCount;
        private System.Windows.Forms.Label guestsInformAllCount;
        private System.Windows.Forms.Label guestsInformLeave;
        private System.Windows.Forms.Label guestsInformAll;
        private System.Windows.Forms.Label hotelPanelTitle;
        private System.Windows.Forms.Panel hotelPanel;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private System.Windows.Forms.GroupBox searchPanel;
        private System.Windows.Forms.Button findGuestsButton;
        private System.Windows.Forms.Button unsettleGuestsButton;
        private System.Windows.Forms.Button settleGuestsButton;
        private System.Windows.Forms.Button showInvoicesButton;
        private System.Windows.Forms.GroupBox editPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem найтиСвободныйНомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заселитьГостейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выселитьГостейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиГостейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьКвитанцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продлитьПребываниеToolStripMenuItem;
        private System.Windows.Forms.Button changeLeaveDateButton;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Panel todayPanel;
        private System.Windows.Forms.Panel staticsPanel;
        private System.Windows.Forms.Button button2;
    }
}

