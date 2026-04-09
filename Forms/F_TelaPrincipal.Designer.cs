namespace Forms
{
    partial class F_TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_TelaPrincipal));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novaToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            salvarComoToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            telaCheiaParaPDFToolStripMenuItem = new ToolStripMenuItem();
            formulárioPDFToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            imprimirToolStripMenuItem = new ToolStripMenuItem();
            visualizarImpressãoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            funcionalidadesToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            recortarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selecionarTudoToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            personalizarToolStripMenuItem = new ToolStripMenuItem();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            janelaToolStripMenuItem = new ToolStripMenuItem();
            organizarToolStripMenuItem = new ToolStripMenuItem();
            cascataToolStripMenuItem = new ToolStripMenuItem();
            ladoALadoToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator9 = new ToolStripSeparator();
            fecharTudoToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sumárioToolStripMenuItem = new ToolStripMenuItem();
            índiceToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            toolStripButton8 = new ToolStripButton();
            toolStripButton9 = new ToolStripButton();
            toolStripButton10 = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripButton11 = new ToolStripButton();
            txtBuscar = new ToolStripTextBox();
            toolStripButton12 = new ToolStripButton();
            dgvExibirAlunos = new DataGridView();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExibirAlunos).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, funcionalidadesToolStripMenuItem, editarToolStripMenuItem, ferramentasToolStripMenuItem, janelaToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(5, 0);
            menuStrip1.MdiWindowListItem = janelaToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(790, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novaToolStripMenuItem, abrirToolStripMenuItem, toolStripSeparator, salvarToolStripMenuItem, salvarComoToolStripMenuItem, exportarToolStripMenuItem, toolStripSeparator1, imprimirToolStripMenuItem, visualizarImpressãoToolStripMenuItem, toolStripSeparator2, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // novaToolStripMenuItem
            // 
            novaToolStripMenuItem.Image = (Image)resources.GetObject("novaToolStripMenuItem.Image");
            novaToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            novaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            novaToolStripMenuItem.Size = new Size(180, 22);
            novaToolStripMenuItem.Text = "&Nova";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Image = Properties.Resources.abrir;
            abrirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "&Abrir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(177, 6);
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Image = Properties.Resources.salvar;
            salvarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "&Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            salvarComoToolStripMenuItem.Size = new Size(180, 22);
            salvarComoToolStripMenuItem.Text = "Salvar &Como";
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { telaCheiaParaPDFToolStripMenuItem, formulárioPDFToolStripMenuItem });
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(180, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            // 
            // telaCheiaParaPDFToolStripMenuItem
            // 
            telaCheiaParaPDFToolStripMenuItem.Name = "telaCheiaParaPDFToolStripMenuItem";
            telaCheiaParaPDFToolStripMenuItem.Size = new Size(156, 22);
            telaCheiaParaPDFToolStripMenuItem.Text = "Tela Cheia PDF";
            telaCheiaParaPDFToolStripMenuItem.Click += telaCheiaParaPDFToolStripMenuItem_Click;
            // 
            // formulárioPDFToolStripMenuItem
            // 
            formulárioPDFToolStripMenuItem.Name = "formulárioPDFToolStripMenuItem";
            formulárioPDFToolStripMenuItem.Size = new Size(156, 22);
            formulárioPDFToolStripMenuItem.Text = "Formulário PDF";
            formulárioPDFToolStripMenuItem.Click += formulárioPDFToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            imprimirToolStripMenuItem.Image = (Image)resources.GetObject("imprimirToolStripMenuItem.Image");
            imprimirToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            imprimirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            imprimirToolStripMenuItem.Size = new Size(180, 22);
            imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // visualizarImpressãoToolStripMenuItem
            // 
            visualizarImpressãoToolStripMenuItem.Image = Properties.Resources.visuualizar_impressao;
            visualizarImpressãoToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            visualizarImpressãoToolStripMenuItem.Name = "visualizarImpressãoToolStripMenuItem";
            visualizarImpressãoToolStripMenuItem.Size = new Size(180, 22);
            visualizarImpressãoToolStripMenuItem.Text = "Visualizar Im&pressão";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "S&air";
            // 
            // funcionalidadesToolStripMenuItem
            // 
            funcionalidadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, excluirToolStripMenuItem, atualizarToolStripMenuItem, listarToolStripMenuItem });
            funcionalidadesToolStripMenuItem.Name = "funcionalidadesToolStripMenuItem";
            funcionalidadesToolStripMenuItem.Size = new Size(105, 20);
            funcionalidadesToolStripMenuItem.Text = "&Funcionalidades";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Image = Properties.Resources.adicionar;
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.C;
            cadastrarToolStripMenuItem.Size = new Size(189, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Image = Properties.Resources.excluir;
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.E;
            excluirToolStripMenuItem.Size = new Size(189, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.Image = Properties.Resources.atualizar;
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.A;
            atualizarToolStripMenuItem.Size = new Size(189, 22);
            atualizarToolStripMenuItem.Text = "Atualizar";
            atualizarToolStripMenuItem.Click += atualizarToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Image = Properties.Resources.relatorio;
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.L;
            listarToolStripMenuItem.Size = new Size(189, 22);
            listarToolStripMenuItem.Text = "Listar";
            listarToolStripMenuItem.Click += listarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { desfazerToolStripMenuItem, refazerToolStripMenuItem, toolStripSeparator3, recortarToolStripMenuItem, copiarToolStripMenuItem, colarToolStripMenuItem, toolStripSeparator4, selecionarTudoToolStripMenuItem });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "&Editar";
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            desfazerToolStripMenuItem.Size = new Size(159, 22);
            desfazerToolStripMenuItem.Text = "&Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            refazerToolStripMenuItem.Size = new Size(159, 22);
            refazerToolStripMenuItem.Text = "&Refazer";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(156, 6);
            // 
            // recortarToolStripMenuItem
            // 
            recortarToolStripMenuItem.Image = Properties.Resources.recortar;
            recortarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            recortarToolStripMenuItem.Name = "recortarToolStripMenuItem";
            recortarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            recortarToolStripMenuItem.Size = new Size(159, 22);
            recortarToolStripMenuItem.Text = "Recor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Image = Properties.Resources.copiar;
            copiarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copiarToolStripMenuItem.Size = new Size(159, 22);
            copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Image = Properties.Resources.colar;
            colarToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            colarToolStripMenuItem.Size = new Size(159, 22);
            colarToolStripMenuItem.Text = "&Colar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(156, 6);
            // 
            // selecionarTudoToolStripMenuItem
            // 
            selecionarTudoToolStripMenuItem.Name = "selecionarTudoToolStripMenuItem";
            selecionarTudoToolStripMenuItem.Size = new Size(159, 22);
            selecionarTudoToolStripMenuItem.Text = "Selecionar &Tudo";
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personalizarToolStripMenuItem, opçõesToolStripMenuItem });
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramen&tas";
            // 
            // personalizarToolStripMenuItem
            // 
            personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            personalizarToolStripMenuItem.Size = new Size(137, 22);
            personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(137, 22);
            opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // janelaToolStripMenuItem
            // 
            janelaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { organizarToolStripMenuItem, toolStripSeparator9, fecharTudoToolStripMenuItem });
            janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            janelaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Delete;
            janelaToolStripMenuItem.Size = new Size(51, 20);
            janelaToolStripMenuItem.Text = "&Janela";
            // 
            // organizarToolStripMenuItem
            // 
            organizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cascataToolStripMenuItem, ladoALadoToolStripMenuItem, verticalToolStripMenuItem });
            organizarToolStripMenuItem.Name = "organizarToolStripMenuItem";
            organizarToolStripMenuItem.Size = new Size(214, 22);
            organizarToolStripMenuItem.Text = "Organizar";
            // 
            // cascataToolStripMenuItem
            // 
            cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            cascataToolStripMenuItem.Size = new Size(138, 22);
            cascataToolStripMenuItem.Text = "Cascata";
            cascataToolStripMenuItem.Click += cascataToolStripMenuItem_Click;
            // 
            // ladoALadoToolStripMenuItem
            // 
            ladoALadoToolStripMenuItem.Name = "ladoALadoToolStripMenuItem";
            ladoALadoToolStripMenuItem.Size = new Size(138, 22);
            ladoALadoToolStripMenuItem.Text = "Lado a Lado";
            ladoALadoToolStripMenuItem.Click += ladoALadoToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(138, 22);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(211, 6);
            // 
            // fecharTudoToolStripMenuItem
            // 
            fecharTudoToolStripMenuItem.Name = "fecharTudoToolStripMenuItem";
            fecharTudoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.D;
            fecharTudoToolStripMenuItem.Size = new Size(214, 22);
            fecharTudoToolStripMenuItem.Text = "Fechar Tudo";
            fecharTudoToolStripMenuItem.Click += fecharTudoToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sumárioToolStripMenuItem, índiceToolStripMenuItem, pesquisarToolStripMenuItem, toolStripSeparator5, sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // sumárioToolStripMenuItem
            // 
            sumárioToolStripMenuItem.Image = Properties.Resources.ajuda;
            sumárioToolStripMenuItem.Name = "sumárioToolStripMenuItem";
            sumárioToolStripMenuItem.Size = new Size(124, 22);
            sumárioToolStripMenuItem.Text = "&Sumário";
            // 
            // índiceToolStripMenuItem
            // 
            índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            índiceToolStripMenuItem.Size = new Size(124, 22);
            índiceToolStripMenuItem.Text = "&Índice";
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(124, 22);
            pesquisarToolStripMenuItem.Text = "&Pesquisar";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(121, 6);
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(124, 22);
            sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator6, toolStripButton4, toolStripButton5, toolStripButton6, toolStripSeparator7, toolStripButton7, toolStripButton8, toolStripButton9, toolStripButton10, toolStripSeparator8, toolStripButton11, txtBuscar, toolStripButton12 });
            toolStrip1.Location = new Point(5, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(790, 50);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.abrir;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(5, 0, 5, 0);
            toolStripButton1.Size = new Size(30, 47);
            toolStripButton1.Text = "Abrir";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.salvar;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Padding = new Padding(5, 0, 5, 0);
            toolStripButton2.Size = new Size(30, 47);
            toolStripButton2.Text = "Salvar Como";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.visuualizar_impressao;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Padding = new Padding(5, 0, 5, 0);
            toolStripButton3.Size = new Size(30, 47);
            toolStripButton3.Text = "Imprimir";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 50);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = Properties.Resources.recortar;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Padding = new Padding(5, 0, 5, 0);
            toolStripButton4.Size = new Size(30, 47);
            toolStripButton4.Text = "Recortar";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.copiar;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Padding = new Padding(5, 0, 5, 0);
            toolStripButton5.Size = new Size(30, 47);
            toolStripButton5.Text = "Copiar";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = Properties.Resources.colar;
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Padding = new Padding(5, 0, 5, 0);
            toolStripButton6.Size = new Size(30, 47);
            toolStripButton6.Text = "Colar";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 50);
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = Properties.Resources.adicionar;
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Padding = new Padding(5, 0, 5, 0);
            toolStripButton7.Size = new Size(30, 47);
            toolStripButton7.Text = "Cadastrar";
            toolStripButton7.Click += toolStripButton7_Click;
            // 
            // toolStripButton8
            // 
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton8.Image = Properties.Resources.excluir;
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Padding = new Padding(5, 0, 5, 0);
            toolStripButton8.Size = new Size(30, 47);
            toolStripButton8.Text = "Excluir";
            toolStripButton8.Click += toolStripButton8_Click;
            // 
            // toolStripButton9
            // 
            toolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton9.Image = Properties.Resources.atualizar;
            toolStripButton9.ImageTransparentColor = Color.Magenta;
            toolStripButton9.Name = "toolStripButton9";
            toolStripButton9.Padding = new Padding(5, 0, 5, 0);
            toolStripButton9.Size = new Size(30, 47);
            toolStripButton9.Text = "Alterar";
            toolStripButton9.Click += toolStripButton9_Click;
            // 
            // toolStripButton10
            // 
            toolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton10.Image = Properties.Resources.relatorio;
            toolStripButton10.ImageTransparentColor = Color.Magenta;
            toolStripButton10.Name = "toolStripButton10";
            toolStripButton10.Padding = new Padding(5, 0, 5, 0);
            toolStripButton10.Size = new Size(30, 47);
            toolStripButton10.Text = "Listar";
            toolStripButton10.Click += toolStripButton10_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 50);
            // 
            // toolStripButton11
            // 
            toolStripButton11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton11.Image = Properties.Resources.ajuda;
            toolStripButton11.ImageTransparentColor = Color.Magenta;
            toolStripButton11.Name = "toolStripButton11";
            toolStripButton11.Padding = new Padding(5, 0, 5, 0);
            toolStripButton11.Size = new Size(30, 47);
            toolStripButton11.Text = "Ajuda";
            // 
            // txtBuscar
            // 
            txtBuscar.Alignment = ToolStripItemAlignment.Right;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 50);
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // toolStripButton12
            // 
            toolStripButton12.Alignment = ToolStripItemAlignment.Right;
            toolStripButton12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton12.Image = Properties.Resources.buscar;
            toolStripButton12.ImageTransparentColor = Color.Magenta;
            toolStripButton12.Name = "toolStripButton12";
            toolStripButton12.Size = new Size(23, 47);
            toolStripButton12.Text = "Buscar";
            toolStripButton12.Click += toolStripButton12_Click;
            // 
            // dgvExibirAlunos
            // 
            dgvExibirAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExibirAlunos.BackgroundColor = Color.Gray;
            dgvExibirAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExibirAlunos.Dock = DockStyle.Bottom;
            dgvExibirAlunos.Location = new Point(5, 185);
            dgvExibirAlunos.Name = "dgvExibirAlunos";
            dgvExibirAlunos.Size = new Size(790, 412);
            dgvExibirAlunos.TabIndex = 3;
            dgvExibirAlunos.Visible = false;
            dgvExibirAlunos.DoubleClick += dgvExibirAlunos_DoubleClick;
            // 
            // F_TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 597);
            Controls.Add(dgvExibirAlunos);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "F_TelaPrincipal";
            Padding = new Padding(5, 0, 5, 0);
            Text = "[SGA] Sistema de Gerenciamento de Alunos";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExibirAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem novaToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripMenuItem salvarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem visualizarImpressãoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem funcionalidadesToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem recortarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selecionarTudoToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem personalizarToolStripMenuItem;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sumárioToolStripMenuItem;
        private ToolStripMenuItem índiceToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripButton toolStripButton10;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton11;
        private ToolStripTextBox txtBuscar;
        private ToolStripButton toolStripButton12;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private DataGridView dgvExibirAlunos;
        private ToolStripMenuItem janelaToolStripMenuItem;
        private ToolStripMenuItem organizarToolStripMenuItem;
        private ToolStripMenuItem cascataToolStripMenuItem;
        private ToolStripMenuItem ladoALadoToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem fecharTudoToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem telaCheiaParaPDFToolStripMenuItem;
        private ToolStripMenuItem formulárioPDFToolStripMenuItem;
    }
}
