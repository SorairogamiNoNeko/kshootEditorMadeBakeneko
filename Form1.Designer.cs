namespace kshootEditorMadeBakeneko
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
			this.mainBox = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新規作成NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.名前を付けて保存AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.終了CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.元に戻すUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.やり直しRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.切り取りToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.貼り付けPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.全て選択AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.選択を解除LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.選択ノーツを左右反転RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.選択ノーツのレーンをランダム入れ替えToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.選択中のToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.選択範囲の傾きをコピーIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.選択範囲の傾きエフェクトを削除NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.選択範囲のをコピーIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.選択範囲のレーンの拡大をコピーOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
			this.選択範囲の領域を削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.カーソル位置の空白をToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.カーソル位置の時間を表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.選曲ﾌﾟﾚﾋﾞｭｰToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
			this.すべてのToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.譜面内容をクリアHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
			this.譜面に関する設定全般TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.譜面に関する設定詳細MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ツールTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.再生PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			((System.ComponentModel.ISupportInitialize)(this.mainBox)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainBox
			// 
			this.mainBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mainBox.BackColor = System.Drawing.Color.Black;
			this.mainBox.Location = new System.Drawing.Point(150, 49);
			this.mainBox.Margin = new System.Windows.Forms.Padding(0);
			this.mainBox.Name = "mainBox";
			this.mainBox.Size = new System.Drawing.Size(880, 620);
			this.mainBox.TabIndex = 0;
			this.mainBox.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ツールTToolStripMenuItem,
            this.再生PToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ファイルFToolStripMenuItem
			// 
			this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripMenuItem,
            this.開くOToolStripMenuItem,
            this.toolStripMenuItem1,
            this.保存SToolStripMenuItem,
            this.名前を付けて保存AToolStripMenuItem,
            this.toolStripMenuItem2,
            this.終了CToolStripMenuItem});
			this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
			this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
			// 
			// 新規作成NToolStripMenuItem
			// 
			this.新規作成NToolStripMenuItem.Name = "新規作成NToolStripMenuItem";
			this.新規作成NToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.新規作成NToolStripMenuItem.Text = "新規作成(N)";
			// 
			// 開くOToolStripMenuItem
			// 
			this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
			this.開くOToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.開くOToolStripMenuItem.Text = "開く(O)...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// 保存SToolStripMenuItem
			// 
			this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
			this.保存SToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.保存SToolStripMenuItem.Text = "保存(S)";
			// 
			// 名前を付けて保存AToolStripMenuItem
			// 
			this.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem";
			this.名前を付けて保存AToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(A)...";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
			// 
			// 終了CToolStripMenuItem
			// 
			this.終了CToolStripMenuItem.Name = "終了CToolStripMenuItem";
			this.終了CToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.終了CToolStripMenuItem.Text = "終了(C)";
			// 
			// 編集EToolStripMenuItem
			// 
			this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すUToolStripMenuItem,
            this.やり直しRToolStripMenuItem,
            this.toolStripMenuItem3,
            this.切り取りToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けPToolStripMenuItem,
            this.削除DToolStripMenuItem,
            this.toolStripMenuItem4,
            this.全て選択AToolStripMenuItem,
            this.選択を解除LToolStripMenuItem,
            this.toolStripMenuItem5,
            this.選択ノーツを左右反転RToolStripMenuItem,
            this.選択ノーツのレーンをランダム入れ替えToolStripMenuItem,
            this.選択中のToolStripMenuItem,
            this.toolStripMenuItem6,
            this.選択範囲の傾きをコピーIToolStripMenuItem,
            this.選択範囲の傾きエフェクトを削除NToolStripMenuItem,
            this.toolStripMenuItem7,
            this.選択範囲のをコピーIToolStripMenuItem,
            this.選択範囲のレーンの拡大をコピーOToolStripMenuItem,
            this.toolStripMenuItem8,
            this.選択範囲の領域を削除ToolStripMenuItem,
            this.カーソル位置の空白をToolStripMenuItem,
            this.カーソル位置の時間を表示VToolStripMenuItem,
            this.選曲ﾌﾟﾚﾋﾞｭｰToolStripMenuItem,
            this.toolStripMenuItem9,
            this.すべてのToolStripMenuItem,
            this.譜面内容をクリアHToolStripMenuItem,
            this.toolStripMenuItem10,
            this.譜面に関する設定全般TToolStripMenuItem,
            this.譜面に関する設定詳細MToolStripMenuItem});
			this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
			this.編集EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.編集EToolStripMenuItem.Text = "編集(E)";
			// 
			// 元に戻すUToolStripMenuItem
			// 
			this.元に戻すUToolStripMenuItem.Name = "元に戻すUToolStripMenuItem";
			this.元に戻すUToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.元に戻すUToolStripMenuItem.Text = "元に戻す(U)";
			// 
			// やり直しRToolStripMenuItem
			// 
			this.やり直しRToolStripMenuItem.Name = "やり直しRToolStripMenuItem";
			this.やり直しRToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.やり直しRToolStripMenuItem.Text = "やり直し(R)";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(299, 6);
			// 
			// 切り取りToolStripMenuItem
			// 
			this.切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem";
			this.切り取りToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.切り取りToolStripMenuItem.Text = "切り取り(T)";
			// 
			// コピーCToolStripMenuItem
			// 
			this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
			this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.コピーCToolStripMenuItem.Text = "コピー(C)";
			// 
			// 貼り付けPToolStripMenuItem
			// 
			this.貼り付けPToolStripMenuItem.Name = "貼り付けPToolStripMenuItem";
			this.貼り付けPToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.貼り付けPToolStripMenuItem.Text = "貼り付け(P)";
			// 
			// 削除DToolStripMenuItem
			// 
			this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
			this.削除DToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.削除DToolStripMenuItem.Text = "削除(D)";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(299, 6);
			// 
			// 全て選択AToolStripMenuItem
			// 
			this.全て選択AToolStripMenuItem.Name = "全て選択AToolStripMenuItem";
			this.全て選択AToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.全て選択AToolStripMenuItem.Text = "全て選択(A)";
			// 
			// 選択を解除LToolStripMenuItem
			// 
			this.選択を解除LToolStripMenuItem.Name = "選択を解除LToolStripMenuItem";
			this.選択を解除LToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択を解除LToolStripMenuItem.Text = "選択を解除(L)";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(299, 6);
			// 
			// 選択ノーツを左右反転RToolStripMenuItem
			// 
			this.選択ノーツを左右反転RToolStripMenuItem.Name = "選択ノーツを左右反転RToolStripMenuItem";
			this.選択ノーツを左右反転RToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択ノーツを左右反転RToolStripMenuItem.Text = "選択ノーツを左右反転(F)";
			// 
			// 選択ノーツのレーンをランダム入れ替えToolStripMenuItem
			// 
			this.選択ノーツのレーンをランダム入れ替えToolStripMenuItem.Name = "選択ノーツのレーンをランダム入れ替えToolStripMenuItem";
			this.選択ノーツのレーンをランダム入れ替えToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択ノーツのレーンをランダム入れ替えToolStripMenuItem.Text = "選択ノーツのレーンをランダム入れ替え(R)";
			// 
			// 選択中のToolStripMenuItem
			// 
			this.選択中のToolStripMenuItem.Name = "選択中のToolStripMenuItem";
			this.選択中のToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択中のToolStripMenuItem.Text = "選択中のLAZERオブジェクトの色を反転(W)";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(299, 6);
			// 
			// 選択範囲の傾きをコピーIToolStripMenuItem
			// 
			this.選択範囲の傾きをコピーIToolStripMenuItem.Name = "選択範囲の傾きをコピーIToolStripMenuItem";
			this.選択範囲の傾きをコピーIToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択範囲の傾きをコピーIToolStripMenuItem.Text = "選択範囲の傾きエフェクトをコピー(I)";
			this.選択範囲の傾きをコピーIToolStripMenuItem.Click += new System.EventHandler(this.選択範囲の傾きをコピーIToolStripMenuItem_Click);
			// 
			// 選択範囲の傾きエフェクトを削除NToolStripMenuItem
			// 
			this.選択範囲の傾きエフェクトを削除NToolStripMenuItem.Name = "選択範囲の傾きエフェクトを削除NToolStripMenuItem";
			this.選択範囲の傾きエフェクトを削除NToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択範囲の傾きエフェクトを削除NToolStripMenuItem.Text = "選択範囲の傾きエフェクトを削除(N)";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(299, 6);
			// 
			// 選択範囲のをコピーIToolStripMenuItem
			// 
			this.選択範囲のをコピーIToolStripMenuItem.Name = "選択範囲のをコピーIToolStripMenuItem";
			this.選択範囲のをコピーIToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択範囲のをコピーIToolStripMenuItem.Text = "選択範囲のレーンの拡大をコピー(Z)";
			// 
			// 選択範囲のレーンの拡大をコピーOToolStripMenuItem
			// 
			this.選択範囲のレーンの拡大をコピーOToolStripMenuItem.Name = "選択範囲のレーンの拡大をコピーOToolStripMenuItem";
			this.選択範囲のレーンの拡大をコピーOToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択範囲のレーンの拡大をコピーOToolStripMenuItem.Text = "選択範囲のレーンの拡大をコピー(O)";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(299, 6);
			// 
			// 選択範囲の領域を削除ToolStripMenuItem
			// 
			this.選択範囲の領域を削除ToolStripMenuItem.Name = "選択範囲の領域を削除ToolStripMenuItem";
			this.選択範囲の領域を削除ToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選択範囲の領域を削除ToolStripMenuItem.Text = "選択範囲の領域を削除(E)...";
			// 
			// カーソル位置の空白をToolStripMenuItem
			// 
			this.カーソル位置の空白をToolStripMenuItem.Name = "カーソル位置の空白をToolStripMenuItem";
			this.カーソル位置の空白をToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.カーソル位置の空白をToolStripMenuItem.Text = "カーソル位置の空白を挿入(B)...";
			// 
			// カーソル位置の時間を表示VToolStripMenuItem
			// 
			this.カーソル位置の時間を表示VToolStripMenuItem.Name = "カーソル位置の時間を表示VToolStripMenuItem";
			this.カーソル位置の時間を表示VToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.カーソル位置の時間を表示VToolStripMenuItem.Text = "カーソル位置の時間を表示(V)...";
			// 
			// 選曲ﾌﾟﾚﾋﾞｭｰToolStripMenuItem
			// 
			this.選曲ﾌﾟﾚﾋﾞｭｰToolStripMenuItem.Name = "選曲ﾌﾟﾚﾋﾞｭｰToolStripMenuItem";
			this.選曲ﾌﾟﾚﾋﾞｭｰToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.選曲ﾌﾟﾚﾋﾞｭｰToolStripMenuItem.Text = "選曲ﾌﾟﾚﾋﾞｭｰ先頭をｶｰｿﾙ位置の時間に設定(S)";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(299, 6);
			// 
			// すべてのToolStripMenuItem
			// 
			this.すべてのToolStripMenuItem.Name = "すべてのToolStripMenuItem";
			this.すべてのToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.すべてのToolStripMenuItem.Text = "すべての注釈をクリア(O)";
			this.すべてのToolStripMenuItem.Click += new System.EventHandler(this.すべてのToolStripMenuItem_Click);
			// 
			// 譜面内容をクリアHToolStripMenuItem
			// 
			this.譜面内容をクリアHToolStripMenuItem.Name = "譜面内容をクリアHToolStripMenuItem";
			this.譜面内容をクリアHToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.譜面内容をクリアHToolStripMenuItem.Text = "譜面内容をクリア(H)...";
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(299, 6);
			// 
			// 譜面に関する設定全般TToolStripMenuItem
			// 
			this.譜面に関する設定全般TToolStripMenuItem.Name = "譜面に関する設定全般TToolStripMenuItem";
			this.譜面に関する設定全般TToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.譜面に関する設定全般TToolStripMenuItem.Text = "譜面に関する設定-全般(T)...";
			// 
			// 譜面に関する設定詳細MToolStripMenuItem
			// 
			this.譜面に関する設定詳細MToolStripMenuItem.Name = "譜面に関する設定詳細MToolStripMenuItem";
			this.譜面に関する設定詳細MToolStripMenuItem.Size = new System.Drawing.Size(302, 22);
			this.譜面に関する設定詳細MToolStripMenuItem.Text = "譜面に関する設定-詳細(M)...";
			// 
			// 表示VToolStripMenuItem
			// 
			this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
			this.表示VToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.表示VToolStripMenuItem.Text = "表示(V)";
			// 
			// ツールTToolStripMenuItem
			// 
			this.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem";
			this.ツールTToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.ツールTToolStripMenuItem.Text = "ツール(T)";
			// 
			// 再生PToolStripMenuItem
			// 
			this.再生PToolStripMenuItem.Name = "再生PToolStripMenuItem";
			this.再生PToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.再生PToolStripMenuItem.Text = "再生(P)";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1034, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1034, 671);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.mainBox);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.mainBox)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox mainBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 新規作成NToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 再生PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存AToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem 終了CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 元に戻すUToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem やり直しRToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem 切り取りToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 貼り付けPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem 全て選択AToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 選択を解除LToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem 選択ノーツを左右反転RToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 選択ノーツのレーンをランダム入れ替えToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 選択中のToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem 選択範囲の傾きをコピーIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 選択範囲の傾きエフェクトを削除NToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem 選択範囲のをコピーIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 選択範囲のレーンの拡大をコピーOToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem 選択範囲の領域を削除ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem カーソル位置の空白をToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem カーソル位置の時間を表示VToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 選曲ﾌﾟﾚﾋﾞｭｰToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem すべてのToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 譜面内容をクリアHToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem 譜面に関する設定全般TToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 譜面に関する設定詳細MToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}

