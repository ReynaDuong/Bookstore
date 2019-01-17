namespace Bookstore
{
	partial class BookStoreViewMainPanel
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
			this.MainPanel = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.Clear = new System.Windows.Forms.Button();
			this.SearchInStore = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ISBN = new System.Windows.Forms.TextBox();
			this.AuthorName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Search = new System.Windows.Forms.Button();
			this.BookName = new System.Windows.Forms.TextBox();
			this.sortGroup = new System.Windows.Forms.GroupBox();
			this.sortByCity = new System.Windows.Forms.RadioButton();
			this.sortByState = new System.Windows.Forms.RadioButton();
			this.sortByBookTitle = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.sortDesc = new System.Windows.Forms.RadioButton();
			this.sortAsc = new System.Windows.Forms.RadioButton();
			this.MainPanel.SuspendLayout();
			this.sortGroup.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.Controls.Add(this.groupBox2);
			this.MainPanel.Controls.Add(this.sortGroup);
			this.MainPanel.Controls.Add(this.label4);
			this.MainPanel.Controls.Add(this.Clear);
			this.MainPanel.Controls.Add(this.SearchInStore);
			this.MainPanel.Controls.Add(this.label3);
			this.MainPanel.Controls.Add(this.ISBN);
			this.MainPanel.Controls.Add(this.AuthorName);
			this.MainPanel.Controls.Add(this.label2);
			this.MainPanel.Controls.Add(this.label1);
			this.MainPanel.Controls.Add(this.Search);
			this.MainPanel.Controls.Add(this.BookName);
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(0, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(1189, 723);
			this.MainPanel.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Result";
			// 
			// Clear
			// 
			this.Clear.Location = new System.Drawing.Point(301, 630);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(75, 23);
			this.Clear.TabIndex = 8;
			this.Clear.Text = "Clear";
			this.Clear.UseVisualStyleBackColor = true;
			this.Clear.Click += new System.EventHandler(this.Clear_Click);
			// 
			// SearchInStore
			// 
			this.SearchInStore.Location = new System.Drawing.Point(144, 198);
			this.SearchInStore.Multiline = true;
			this.SearchInStore.Name = "SearchInStore";
			this.SearchInStore.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.SearchInStore.Size = new System.Drawing.Size(819, 271);
			this.SearchInStore.TabIndex = 7;
			this.SearchInStore.WordWrap = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "ISBN";
			// 
			// ISBN
			// 
			this.ISBN.Location = new System.Drawing.Point(144, 148);
			this.ISBN.Name = "ISBN";
			this.ISBN.Size = new System.Drawing.Size(251, 20);
			this.ISBN.TabIndex = 5;
			// 
			// AuthorName
			// 
			this.AuthorName.Location = new System.Drawing.Point(144, 101);
			this.AuthorName.Name = "AuthorName";
			this.AuthorName.Size = new System.Drawing.Size(251, 20);
			this.AuthorName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Author Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Book Name";
			// 
			// Search
			// 
			this.Search.Location = new System.Drawing.Point(144, 630);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(75, 23);
			this.Search.TabIndex = 1;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// BookName
			// 
			this.BookName.Location = new System.Drawing.Point(144, 55);
			this.BookName.Name = "BookName";
			this.BookName.Size = new System.Drawing.Size(251, 20);
			this.BookName.TabIndex = 0;
			// 
			// sortGroup
			// 
			this.sortGroup.Controls.Add(this.sortByBookTitle);
			this.sortGroup.Controls.Add(this.sortByState);
			this.sortGroup.Controls.Add(this.sortByCity);
			this.sortGroup.Location = new System.Drawing.Point(144, 499);
			this.sortGroup.Name = "sortGroup";
			this.sortGroup.Size = new System.Drawing.Size(200, 100);
			this.sortGroup.TabIndex = 10;
			this.sortGroup.TabStop = false;
			this.sortGroup.Text = "Sort By";
			// 
			// sortByCity
			// 
			this.sortByCity.AutoSize = true;
			this.sortByCity.Checked = true;
			this.sortByCity.Location = new System.Drawing.Point(0, 20);
			this.sortByCity.Name = "sortByCity";
			this.sortByCity.Size = new System.Drawing.Size(42, 17);
			this.sortByCity.TabIndex = 0;
			this.sortByCity.TabStop = true;
			this.sortByCity.Text = "City";
			this.sortByCity.UseVisualStyleBackColor = true;
			// 
			// sortByState
			// 
			this.sortByState.AutoSize = true;
			this.sortByState.Location = new System.Drawing.Point(0, 43);
			this.sortByState.Name = "sortByState";
			this.sortByState.Size = new System.Drawing.Size(50, 17);
			this.sortByState.TabIndex = 1;
			this.sortByState.TabStop = true;
			this.sortByState.Text = "State";
			this.sortByState.UseVisualStyleBackColor = true;
			// 
			// sortByBookTitle
			// 
			this.sortByBookTitle.AutoSize = true;
			this.sortByBookTitle.Location = new System.Drawing.Point(0, 67);
			this.sortByBookTitle.Name = "sortByBookTitle";
			this.sortByBookTitle.Size = new System.Drawing.Size(78, 17);
			this.sortByBookTitle.TabIndex = 2;
			this.sortByBookTitle.TabStop = true;
			this.sortByBookTitle.Text = "BookName";
			this.sortByBookTitle.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.sortAsc);
			this.groupBox2.Controls.Add(this.sortDesc);
			this.groupBox2.Location = new System.Drawing.Point(478, 499);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Order";
			// 
			// sortDesc
			// 
			this.sortDesc.AutoSize = true;
			this.sortDesc.Checked = true;
			this.sortDesc.Location = new System.Drawing.Point(0, 43);
			this.sortDesc.Name = "sortDesc";
			this.sortDesc.Size = new System.Drawing.Size(82, 17);
			this.sortDesc.TabIndex = 1;
			this.sortDesc.TabStop = true;
			this.sortDesc.Text = "Descending";
			this.sortDesc.UseMnemonic = false;
			this.sortDesc.UseVisualStyleBackColor = true;
			// 
			// sortAsc
			// 
			this.sortAsc.AutoSize = true;
			this.sortAsc.Location = new System.Drawing.Point(0, 20);
			this.sortAsc.Name = "sortAsc";
			this.sortAsc.Size = new System.Drawing.Size(75, 17);
			this.sortAsc.TabIndex = 0;
			this.sortAsc.Text = "Ascending";
			this.sortAsc.UseVisualStyleBackColor = true;
			// 
			// BookStoreViewMainPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1189, 723);
			this.Controls.Add(this.MainPanel);
			this.Name = "BookStoreViewMainPanel";
			this.Text = "Book Store";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.sortGroup.ResumeLayout(false);
			this.sortGroup.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel MainPanel;
		private System.Windows.Forms.TextBox BookName;
		private System.Windows.Forms.Button Clear;
		private System.Windows.Forms.TextBox SearchInStore;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ISBN;
		private System.Windows.Forms.TextBox AuthorName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton sortDesc;
		private System.Windows.Forms.RadioButton sortAsc;
		private System.Windows.Forms.GroupBox sortGroup;
		private System.Windows.Forms.RadioButton sortByBookTitle;
		private System.Windows.Forms.RadioButton sortByState;
		private System.Windows.Forms.RadioButton sortByCity;
	}
}

