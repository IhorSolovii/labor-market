namespace TopVacancy
{
    partial class TopVacancy
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.vacanciesTabPage = new System.Windows.Forms.TabPage();
            this.employersTabPage = new System.Windows.Forms.TabPage();
            this.cataloguesTabPage = new System.Windows.Forms.TabPage();
            this.vacanciesListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cataloguesListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.clientsListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.vacanciesTabPage.SuspendLayout();
            this.employersTabPage.SuspendLayout();
            this.cataloguesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.vacanciesTabPage);
            this.tabControl.Controls.Add(this.employersTabPage);
            this.tabControl.Controls.Add(this.cataloguesTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1002, 574);
            this.tabControl.TabIndex = 2;
            // 
            // vacanciesTabPage
            // 
            this.vacanciesTabPage.Controls.Add(this.vacanciesListView);
            this.vacanciesTabPage.Controls.Add(this.label1);
            this.vacanciesTabPage.Location = new System.Drawing.Point(4, 25);
            this.vacanciesTabPage.Name = "vacanciesTabPage";
            this.vacanciesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vacanciesTabPage.Size = new System.Drawing.Size(994, 545);
            this.vacanciesTabPage.TabIndex = 0;
            this.vacanciesTabPage.Text = "Ваканції";
            this.vacanciesTabPage.UseVisualStyleBackColor = true;
            // 
            // employersTabPage
            // 
            this.employersTabPage.Controls.Add(this.label3);
            this.employersTabPage.Controls.Add(this.clientsListView);
            this.employersTabPage.Location = new System.Drawing.Point(4, 25);
            this.employersTabPage.Name = "employersTabPage";
            this.employersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employersTabPage.Size = new System.Drawing.Size(994, 545);
            this.employersTabPage.TabIndex = 1;
            this.employersTabPage.Text = "Роботодавці";
            this.employersTabPage.UseVisualStyleBackColor = true;
            // 
            // cataloguesTabPage
            // 
            this.cataloguesTabPage.Controls.Add(this.label2);
            this.cataloguesTabPage.Controls.Add(this.cataloguesListView);
            this.cataloguesTabPage.Location = new System.Drawing.Point(4, 25);
            this.cataloguesTabPage.Name = "cataloguesTabPage";
            this.cataloguesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cataloguesTabPage.Size = new System.Drawing.Size(994, 545);
            this.cataloguesTabPage.TabIndex = 2;
            this.cataloguesTabPage.Text = "Категорії";
            this.cataloguesTabPage.UseVisualStyleBackColor = true;
            // 
            // vacanciesListView
            // 
            this.vacanciesListView.Location = new System.Drawing.Point(6, 52);
            this.vacanciesListView.Name = "vacanciesListView";
            this.vacanciesListView.Size = new System.Drawing.Size(981, 487);
            this.vacanciesListView.TabIndex = 3;
            this.vacanciesListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Most paid vacancies:";
            // 
            // cataloguesListView
            // 
            this.cataloguesListView.Location = new System.Drawing.Point(7, 52);
            this.cataloguesListView.Name = "cataloguesListView";
            this.cataloguesListView.Size = new System.Drawing.Size(981, 487);
            this.cataloguesListView.TabIndex = 4;
            this.cataloguesListView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Most popular categories:";
            // 
            // clientsListView
            // 
            this.clientsListView.Location = new System.Drawing.Point(7, 52);
            this.clientsListView.Name = "clientsListView";
            this.clientsListView.Size = new System.Drawing.Size(981, 487);
            this.clientsListView.TabIndex = 4;
            this.clientsListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biggest Employers:";
            // 
            // TopVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 598);
            this.Controls.Add(this.tabControl);
            this.Name = "TopVacancy";
            this.Text = "Top Vacancy";
            this.tabControl.ResumeLayout(false);
            this.vacanciesTabPage.ResumeLayout(false);
            this.vacanciesTabPage.PerformLayout();
            this.employersTabPage.ResumeLayout(false);
            this.employersTabPage.PerformLayout();
            this.cataloguesTabPage.ResumeLayout(false);
            this.cataloguesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage vacanciesTabPage;
        private System.Windows.Forms.ListView vacanciesListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage employersTabPage;
        private System.Windows.Forms.TabPage cataloguesTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView cataloguesListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView clientsListView;
    }
}

