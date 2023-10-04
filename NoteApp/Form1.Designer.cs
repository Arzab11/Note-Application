namespace NoteApp
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
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleMessage = new System.Windows.Forms.TextBox();
            this.NoteMessage = new System.Windows.Forms.TextBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonView = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.NoteView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NoteView)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(41, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Note";
            // 
            // TitleMessage
            // 
            this.TitleMessage.Location = new System.Drawing.Point(74, 28);
            this.TitleMessage.Name = "TitleMessage";
            this.TitleMessage.Size = new System.Drawing.Size(188, 20);
            this.TitleMessage.TabIndex = 4;
            // 
            // NoteMessage
            // 
            this.NoteMessage.Location = new System.Drawing.Point(74, 73);
            this.NoteMessage.Multiline = true;
            this.NoteMessage.Name = "NoteMessage";
            this.NoteMessage.Size = new System.Drawing.Size(188, 192);
            this.NoteMessage.TabIndex = 1;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.Gray;
            this.ButtonCreate.ForeColor = System.Drawing.Color.White;
            this.ButtonCreate.Location = new System.Drawing.Point(32, 299);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(97, 32);
            this.ButtonCreate.TabIndex = 2;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.Gray;
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(175, 299);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 32);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonView
            // 
            this.ButtonView.BackColor = System.Drawing.Color.Gray;
            this.ButtonView.ForeColor = System.Drawing.Color.White;
            this.ButtonView.Location = new System.Drawing.Point(318, 299);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.Size = new System.Drawing.Size(97, 32);
            this.ButtonView.TabIndex = 2;
            this.ButtonView.Text = "View";
            this.ButtonView.UseVisualStyleBackColor = false;
            this.ButtonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.Gray;
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(461, 299);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(97, 32);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // NoteView
            // 
            this.NoteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteView.Location = new System.Drawing.Point(295, 30);
            this.NoteView.Name = "NoteView";
            this.NoteView.Size = new System.Drawing.Size(263, 235);
            this.NoteView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.NoteView);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonView);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.NoteMessage);
            this.Controls.Add(this.TitleMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoteView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleMessage;
        private System.Windows.Forms.TextBox NoteMessage;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonView;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.DataGridView NoteView;
    }
}

