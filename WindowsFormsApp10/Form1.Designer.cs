namespace WindowsFormsApp10
{
    partial class Form1
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
            this.dtGame = new System.Windows.Forms.DataGridView();
            this.btResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGame)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGame
            // 
            this.dtGame.AllowUserToAddRows = false;
            this.dtGame.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGame.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGame.Location = new System.Drawing.Point(231, 23);
            this.dtGame.Name = "dtGame";
            this.dtGame.ReadOnly = true;
            this.dtGame.RowHeadersWidth = 62;
            this.dtGame.RowTemplate.Height = 28;
            this.dtGame.Size = new System.Drawing.Size(685, 394);
            this.dtGame.TabIndex = 0;
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(36, 164);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(158, 111);
            this.btResult.TabIndex = 1;
            this.btResult.Text = "Спрогнозировать";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 441);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.dtGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGame;
        private System.Windows.Forms.Button btResult;
    }
}

