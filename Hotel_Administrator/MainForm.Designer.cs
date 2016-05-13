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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиСвободныйНомерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFloorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заселитьГостейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выселитьГостейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиГостейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьКвитанцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelInformPanel = new System.Windows.Forms.GroupBox();
            this.hotelInformBusyCount = new System.Windows.Forms.Label();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelInformEmptyCount = new System.Windows.Forms.Label();
            this.hotelInformAllCount = new System.Windows.Forms.Label();
            this.hotelInformBusy = new System.Windows.Forms.Label();
            this.hotelInformEmpty = new System.Windows.Forms.Label();
            this.hotelInformAll = new System.Windows.Forms.Label();
            this.guestsInformPanel = new System.Windows.Forms.GroupBox();
            this.guestsInformLeaveCount = new System.Windows.Forms.Label();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsInformAllCount = new System.Windows.Forms.Label();
            this.guestsInformLeave = new System.Windows.Forms.Label();
            this.guestsInformAll = new System.Windows.Forms.Label();
            this.hotelPanelTitle = new System.Windows.Forms.Label();
            this.hotelPanel = new System.Windows.Forms.Panel();
            this.guestEditPanel = new System.Windows.Forms.GroupBox();
            this.showInvoicesButton = new System.Windows.Forms.Button();
            this.findGuestsButton = new System.Windows.Forms.Button();
            this.unsettleGuestsButton = new System.Windows.Forms.Button();
            this.settleGuestsButton = new System.Windows.Forms.Button();
            this.hotelEditPanel = new System.Windows.Forms.GroupBox();
            this.deleteRoomsButton = new System.Windows.Forms.Button();
            this.addRoomsButton = new System.Windows.Forms.Button();
            this.deleteFloorButton = new System.Windows.Forms.Button();
            this.addFloorButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.hotelInformPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.guestsInformPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            this.guestEditPanel.SuspendLayout();
            this.hotelEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HotelToolStripMenuItem,
            this.GuestsToolStripMenuItem});
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
            // GuestsToolStripMenuItem
            // 
            this.GuestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заселитьГостейToolStripMenuItem,
            this.выселитьГостейToolStripMenuItem,
            this.найтиГостейToolStripMenuItem,
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
            // 
            // выселитьГостейToolStripMenuItem
            // 
            this.выселитьГостейToolStripMenuItem.Name = "выселитьГостейToolStripMenuItem";
            this.выселитьГостейToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.выселитьГостейToolStripMenuItem.Text = "Выселить гостей";
            // 
            // найтиГостейToolStripMenuItem
            // 
            this.найтиГостейToolStripMenuItem.Name = "найтиГостейToolStripMenuItem";
            this.найтиГостейToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.найтиГостейToolStripMenuItem.Text = "Найти гостей";
            // 
            // посмотретьКвитанцииToolStripMenuItem
            // 
            this.посмотретьКвитанцииToolStripMenuItem.Name = "посмотретьКвитанцииToolStripMenuItem";
            this.посмотретьКвитанцииToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.посмотретьКвитанцииToolStripMenuItem.Text = "Посмотреть квитанции";
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
            this.hotelInformPanel.Location = new System.Drawing.Point(726, 38);
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
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(Hotel_Administrator.Hotel);
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
            this.guestsInformPanel.Location = new System.Drawing.Point(726, 201);
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
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataSource = typeof(Hotel_Administrator.Guests);
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
            // guestEditPanel
            // 
            this.guestEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guestEditPanel.Controls.Add(this.showInvoicesButton);
            this.guestEditPanel.Controls.Add(this.findGuestsButton);
            this.guestEditPanel.Controls.Add(this.unsettleGuestsButton);
            this.guestEditPanel.Controls.Add(this.settleGuestsButton);
            this.guestEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestEditPanel.Location = new System.Drawing.Point(726, 326);
            this.guestEditPanel.Name = "guestEditPanel";
            this.guestEditPanel.Size = new System.Drawing.Size(238, 215);
            this.guestEditPanel.TabIndex = 23;
            this.guestEditPanel.TabStop = false;
            this.guestEditPanel.Text = "Управление гостями";
            // 
            // showInvoicesButton
            // 
            this.showInvoicesButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.showInvoicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showInvoicesButton.Location = new System.Drawing.Point(31, 169);
            this.showInvoicesButton.Name = "showInvoicesButton";
            this.showInvoicesButton.Size = new System.Drawing.Size(180, 28);
            this.showInvoicesButton.TabIndex = 3;
            this.showInvoicesButton.Text = "Просмотреть квитанции";
            this.showInvoicesButton.UseVisualStyleBackColor = false;
            // 
            // findGuestsButton
            // 
            this.findGuestsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.findGuestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findGuestsButton.Location = new System.Drawing.Point(31, 124);
            this.findGuestsButton.Name = "findGuestsButton";
            this.findGuestsButton.Size = new System.Drawing.Size(180, 28);
            this.findGuestsButton.TabIndex = 2;
            this.findGuestsButton.Text = "Найти гостей";
            this.findGuestsButton.UseVisualStyleBackColor = false;
            // 
            // unsettleGuestsButton
            // 
            this.unsettleGuestsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.unsettleGuestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unsettleGuestsButton.Location = new System.Drawing.Point(31, 79);
            this.unsettleGuestsButton.Name = "unsettleGuestsButton";
            this.unsettleGuestsButton.Size = new System.Drawing.Size(180, 28);
            this.unsettleGuestsButton.TabIndex = 1;
            this.unsettleGuestsButton.Text = "Выселить гостей";
            this.unsettleGuestsButton.UseVisualStyleBackColor = false;
            // 
            // settleGuestsButton
            // 
            this.settleGuestsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.settleGuestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settleGuestsButton.Location = new System.Drawing.Point(31, 34);
            this.settleGuestsButton.Name = "settleGuestsButton";
            this.settleGuestsButton.Size = new System.Drawing.Size(180, 28);
            this.settleGuestsButton.TabIndex = 0;
            this.settleGuestsButton.Text = "Заселить гостей";
            this.settleGuestsButton.UseVisualStyleBackColor = false;
            // 
            // hotelEditPanel
            // 
            this.hotelEditPanel.Controls.Add(this.deleteRoomsButton);
            this.hotelEditPanel.Controls.Add(this.addRoomsButton);
            this.hotelEditPanel.Controls.Add(this.deleteFloorButton);
            this.hotelEditPanel.Controls.Add(this.addFloorButton);
            this.hotelEditPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotelEditPanel.Location = new System.Drawing.Point(12, 553);
            this.hotelEditPanel.Name = "hotelEditPanel";
            this.hotelEditPanel.Size = new System.Drawing.Size(697, 84);
            this.hotelEditPanel.TabIndex = 24;
            this.hotelEditPanel.TabStop = false;
            this.hotelEditPanel.Text = "Управление гостинницей";
            // 
            // deleteRoomsButton
            // 
            this.deleteRoomsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteRoomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRoomsButton.Location = new System.Drawing.Point(539, 36);
            this.deleteRoomsButton.Name = "deleteRoomsButton";
            this.deleteRoomsButton.Size = new System.Drawing.Size(147, 28);
            this.deleteRoomsButton.TabIndex = 7;
            this.deleteRoomsButton.Text = "Удалить номер";
            this.deleteRoomsButton.UseVisualStyleBackColor = false;
            this.deleteRoomsButton.Click += new System.EventHandler(this.deleteRoom_Click);
            // 
            // addRoomsButton
            // 
            this.addRoomsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addRoomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRoomsButton.Location = new System.Drawing.Point(360, 36);
            this.addRoomsButton.Name = "addRoomsButton";
            this.addRoomsButton.Size = new System.Drawing.Size(161, 28);
            this.addRoomsButton.TabIndex = 6;
            this.addRoomsButton.Text = "Добавить номер(а)";
            this.addRoomsButton.UseVisualStyleBackColor = false;
            this.addRoomsButton.Click += new System.EventHandler(this.addRooms_Click);
            // 
            // deleteFloorButton
            // 
            this.deleteFloorButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteFloorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteFloorButton.Location = new System.Drawing.Point(162, 36);
            this.deleteFloorButton.Name = "deleteFloorButton";
            this.deleteFloorButton.Size = new System.Drawing.Size(180, 28);
            this.deleteFloorButton.TabIndex = 5;
            this.deleteFloorButton.Text = "Удалить верхний этаж";
            this.deleteFloorButton.UseVisualStyleBackColor = false;
            this.deleteFloorButton.Click += new System.EventHandler(this.deleteFloor_Click);
            // 
            // addFloorButton
            // 
            this.addFloorButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addFloorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFloorButton.Location = new System.Drawing.Point(9, 36);
            this.addFloorButton.Name = "addFloorButton";
            this.addFloorButton.Size = new System.Drawing.Size(137, 28);
            this.addFloorButton.TabIndex = 4;
            this.addFloorButton.Text = "Добавить этаж";
            this.addFloorButton.UseVisualStyleBackColor = false;
            this.addFloorButton.Click += new System.EventHandler(this.addFloor_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(757, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Найти свободный номер";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.findEmptyRooms_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hotelEditPanel);
            this.Controls.Add(this.guestEditPanel);
            this.Controls.Add(this.hotelPanelTitle);
            this.Controls.Add(this.guestsInformPanel);
            this.Controls.Add(this.hotelInformPanel);
            this.Controls.Add(this.hotelPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(10000, 688);
            this.MinimumSize = new System.Drawing.Size(992, 688);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор гостинницы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.hotelInformPanel.ResumeLayout(false);
            this.hotelInformPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.guestsInformPanel.ResumeLayout(false);
            this.guestsInformPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            this.guestEditPanel.ResumeLayout(false);
            this.hotelEditPanel.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox guestEditPanel;
        private System.Windows.Forms.Button findGuestsButton;
        private System.Windows.Forms.Button unsettleGuestsButton;
        private System.Windows.Forms.Button settleGuestsButton;
        private System.Windows.Forms.Button showInvoicesButton;
        private System.Windows.Forms.GroupBox hotelEditPanel;
        private System.Windows.Forms.Button deleteFloorButton;
        private System.Windows.Forms.Button addFloorButton;
        private System.Windows.Forms.Button deleteRoomsButton;
        private System.Windows.Forms.Button addRoomsButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem найтиСвободныйНомерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заселитьГостейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выселитьГостейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиГостейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьКвитанцииToolStripMenuItem;
    }
}

