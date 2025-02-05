
namespace 共同開発アプリ
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.BT_hamano = new System.Windows.Forms.Button();
			this.BT_nakayama = new System.Windows.Forms.Button();
			this.BT_ohminato = new System.Windows.Forms.Button();
			this.BT_kawaguti = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BT_hamano
			// 
			this.BT_hamano.Location = new System.Drawing.Point(46, 206);
			this.BT_hamano.Name = "BT_hamano";
			this.BT_hamano.Size = new System.Drawing.Size(101, 46);
			this.BT_hamano.TabIndex = 0;
			this.BT_hamano.Text = "濱野";
			this.BT_hamano.UseVisualStyleBackColor = true;
			// 
			// BT_nakayama
			// 
			this.BT_nakayama.Location = new System.Drawing.Point(207, 206);
			this.BT_nakayama.Name = "BT_nakayama";
			this.BT_nakayama.Size = new System.Drawing.Size(101, 46);
			this.BT_nakayama.TabIndex = 1;
			this.BT_nakayama.Text = "中山";
			this.BT_nakayama.UseVisualStyleBackColor = true;
			// 
			// BT_ohminato
			// 
			this.BT_ohminato.Location = new System.Drawing.Point(350, 202);
			this.BT_ohminato.Name = "BT_ohminato";
			this.BT_ohminato.Size = new System.Drawing.Size(101, 46);
			this.BT_ohminato.TabIndex = 2;
			this.BT_ohminato.Text = "大湊";
			this.BT_ohminato.UseVisualStyleBackColor = true;
			// 
			// BT_kawaguti
			// 
			this.BT_kawaguti.Location = new System.Drawing.Point(501, 202);
			this.BT_kawaguti.Name = "BT_kawaguti";
			this.BT_kawaguti.Size = new System.Drawing.Size(101, 46);
			this.BT_kawaguti.TabIndex = 3;
			this.BT_kawaguti.Text = "河口";
			this.BT_kawaguti.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 450);
			this.Controls.Add(this.BT_kawaguti);
			this.Controls.Add(this.BT_ohminato);
			this.Controls.Add(this.BT_nakayama);
			this.Controls.Add(this.BT_hamano);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BT_hamano;
		private System.Windows.Forms.Button BT_nakayama;
		private System.Windows.Forms.Button BT_ohminato;
		private System.Windows.Forms.Button BT_kawaguti;
	}
}

