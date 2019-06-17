<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TocsvToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Server = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Item = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CurrentBid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MinBid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimeLeft = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bids = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RealmPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GlobalPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RealmQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ItemID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button_Filter = New System.Windows.Forms.Button()
        Me.Button_ClearFilter = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.SToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(851, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotxtToolStripMenuItem, Me.TocsvToolStripMenuItem, Me.ToExcelToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'TotxtToolStripMenuItem
        '
        Me.TotxtToolStripMenuItem.Name = "TotxtToolStripMenuItem"
        Me.TotxtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TotxtToolStripMenuItem.Text = "as .txt"
        '
        'TocsvToolStripMenuItem
        '
        Me.TocsvToolStripMenuItem.Name = "TocsvToolStripMenuItem"
        Me.TocsvToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TocsvToolStripMenuItem.Text = "as .csv"
        '
        'ToExcelToolStripMenuItem
        '
        Me.ToExcelToolStripMenuItem.Name = "ToExcelToolStripMenuItem"
        Me.ToExcelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ToExcelToolStripMenuItem.Text = "to Excel"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Server, Me.Item, Me.CurrentBid, Me.MinBid, Me.TimeLeft, Me.Bids, Me.RealmPrice, Me.GlobalPrice, Me.RealmQty, Me.ItemID})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(149, 33)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowItemToolTips = True
        Me.ListView1.Size = New System.Drawing.Size(691, 264)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Server
        '
        Me.Server.Text = "Server"
        Me.Server.Width = 84
        '
        'Item
        '
        Me.Item.Text = "Item"
        Me.Item.Width = 254
        '
        'CurrentBid
        '
        Me.CurrentBid.Text = "Current Bid"
        Me.CurrentBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CurrentBid.Width = 78
        '
        'MinBid
        '
        Me.MinBid.Text = "Min. Bid"
        Me.MinBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MinBid.Width = 72
        '
        'TimeLeft
        '
        Me.TimeLeft.Text = "Time Left"
        '
        'Bids
        '
        Me.Bids.Text = "# Bids"
        Me.Bids.Width = 59
        '
        'RealmPrice
        '
        Me.RealmPrice.Text = "Realm Price"
        Me.RealmPrice.Width = 101
        '
        'GlobalPrice
        '
        Me.GlobalPrice.Text = "Global Price"
        Me.GlobalPrice.Width = 101
        '
        'RealmQty
        '
        Me.RealmQty.Text = "Realm Qty."
        Me.RealmQty.Width = 65
        '
        'ItemID
        '
        Me.ItemID.Text = "ItemID"
        Me.ItemID.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 152)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Region"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"", "Aegwynn", "Aerie-Peak", "Agamaggan", "Aggramar", "Akama", "Alexstrasza", "Alleria", "Altar-of-Storms", "Alterac-Mountains", "AmanThul", "Andorhal", "Anetheron", "Antonidas", "Anubarak", "Anvilmar", "Arathor", "Archimonde", "Area-52", "Argent-Dawn", "Arthas", "Arygos", "Auchindoun", "Azgalor", "AzjolNerub", "Azralon", "Azshara", "Azuremyst", "Baelgun", "Balnazzar", "Barthilas", "Black-Dragonflight", "Blackhand", "Blackrock", "Blackwater-Raiders", "Blackwing-Lair", "Blades-Edge", "Bladefist", "Bleeding-Hollow", "Blood-Furnace", "Bloodhoof", "Bloodscalp", "Bonechewer", "Borean-Tundra", "Boulderfist", "Bronzebeard", "Burning-Blade", "Burning-Legion", "Caelestrasz", "Cairne", "Cenarion-Circle", "Cenarius", "Chogall", "Chromaggus", "Coilfang", "Crushridge", "Daggerspine", "Dalaran", "Dalvengyr", "Dark-Iron", "Darkspear", "Darrowmere", "DathRemar", "Dawnbringer", "Deathwing", "Demon-Soul", "Dentarg", "Destromath", "Dethecus", "Detheroc", "Doomhammer", "Draenor", "Dragonblight", "Dragonmaw", "DrakTharon", "Drakthul", "Draka", "Drakkari", "Dreadmaul", "Drenden", "Dunemaul", "Durotan", "Duskwood", "Earthen-Ring", "Echo-Isles", "Eitrigg", "EldreThalas", "Elune", "Emerald-Dream", "Eonar", "Eredar", "Executus", "Exodar", "Farstriders", "Feathermoon", "Fenris", "Firetree", "Fizzcrank", "Frostmane", "Frostmourne", "Frostwolf", "Galakrond", "Gallywix", "Garithos", "Garona", "Garrosh", "Ghostlands", "Gilneas", "Gnomeregan", "Goldrinn", "Gorefiend", "Gorgonnash", "Greymane", "Grizzly-Hills", "Guldan", "Gundrak", "Gurubashi", "Hakkar", "Haomarush", "Hellscream", "Hydraxis", "Hyjal", "Icecrown", "Illidan", "Jaedenar", "JubeiThos", "Kaelthas", "Kalecgos", "Kargath", "KelThuzad", "Khadgar", "Khaz-Modan", "Khazgoroth", "Kiljaeden", "Kilrogg", "Kirin-Tor", "Korgath", "Korialstrasz", "Kul-Tiras", "Laughing-Skull", "Lethon", "Lightbringer", "Lightnings-Blade", "Lightninghoof", "Llane", "Lothar", "Madoran", "Maelstrom", "Magtheridon", "Maiev", "MalGanis", "Malfurion", "Malorne", "Malygos", "Mannoroth", "Medivh", "Misha", "MokNathal", "Moon-Guard", "Moonrunner", "Mugthol", "Muradin", "Nagrand", "Nathrezim", "Nazgrel", "Nazjatar", "Nemesis", "Nerzhul", "Nesingwary", "Nordrassil", "Norgannon", "Onyxia", "Perenolde", "Proudmoore", "Queldorei", "QuelThalas", "Ragnaros", "Ravencrest", "Ravenholdt", "Rexxar", "Rivendare", "Runetotem", "Sargeras", "Saurfang", "Scarlet-Crusade", "Scilla", "Senjin", "Sentinels", "Shadow-Council", "Shadowmoon", "Shadowsong", "Shandris", "Shattered-Halls", "Shattered-Hand", "Shuhalo", "Silver-Hand", "Silvermoon", "Sisters-of-Elune", "Skullcrusher", "Skywall", "Smolderthorn", "Spinebreaker", "Spirestone", "Staghelm", "Steamwheedle-Cartel", "Stonemaul", "Stormrage", "Stormreaver", "Stormscale", "Suramar", "Tanaris", "Terenas", "Terokkar", "Thaurissan", "The-Forgotten-Coast", "The-Scryers", "The-Underbog", "The-Venture-Co", "Thorium-Brotherhood", "Thrall", "Thunderhorn", "Thunderlord", "Tichondrius", "Tol-Barad", "Tortheldrin", "Trollbane", "Turalyon", "Twisting-Nether", "Uldaman", "Uldum", "Undermine", "Ursin", "Uther", "Vashj", "Veknilash", "Velen", "Warsong", "Whisperwind", "Wildhammer", "Windrunner", "Winterhoof", "Wyrmrest-Accord", "Ysera", "Ysondre", "Zangarmarsh", "Zuljin", "Zuluhed"})
        Me.ComboBox3.Location = New System.Drawing.Point(18, 70)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(98, 21)
        Me.ComboBox3.TabIndex = 7
        Me.ComboBox3.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"EU - Servers", "US - Servers"})
        Me.ComboBox1.Location = New System.Drawing.Point(18, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(98, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"", "Aegwynn", "Aerie-Peak", "Agamaggan", "Aggra-Portugues", "Aggramar", "AhnQiraj", "AlAkir", "Alexstrasza", "Alleria", "Alonsus", "AmanThul", "Ambossar", "Anachronos", "Anetheron", "Antonidas", "Anubarak", "Arakarahm", "Arathi", "Arathor", "Archimonde", "Area-52", "Argent-Dawn", "Arthas", "Arygos", "Ashenvale", "Aszune", "Auchindoun", "AzjolNerub", "Azshara", "Azuregos", "Azuremyst", "Baelgun", "Balnazzar", "Blackhand", "Blackmoore", "Blackrock", "Blackscar", "Blades-Edge", "Bladefist", "Bloodfeather", "Bloodhoof", "Bloodscalp", "Blutkessel", "Boulderfist", "Bronze-Dragonflight", "Bronzebeard", "Burning-Blade", "Burning-Legion", "Burning-Steppes", "CThun", "Chamber-of-Aspects", "Chants-Eternels", "Chogall", "Chromaggus", "Colinas-Pardas", "Confrerie-du-Thorium", "Conseil-des-Ombres", "Crushridge", "Culte-de-la-Rive-Noire", "Daggerspine", "Dalaran", "Dalvengyr", "Darkmoon-Faire", "Darksorrow", "Darkspear", "Das-Konsortium", "Das-Syndikat", "Deathguard", "Deathweaver", "Deathwing", "Defias-Brotherhood", "Dentarg", "Der-Abyssische-Rat", "Der-Mithrilorden", "Der-Rat-von-Dalaran", "Destromath", "Dethecus", "Die-Aldor", "Die-Arguswacht", "Die-ewige-Wacht", "Die-Nachtwache", "Die-Silberne-Hand", "Die-Todeskrallen", "Doomhammer", "Draenor", "Dragonblight", "Dragonmaw", "Drakthul", "DrekThar", "Dun-Modr", "Dun-Morogh", "Dunemaul", "Durotan", "Earthen-Ring", "Echsenkessel", "Eitrigg", "EldreThalas", "Elune", "Emerald-Dream", "Emeriss", "Eonar", "Eredar", "Eversong", "Executus", "Exodar", "Festung-der-Stürme", "Fordragon", "Forscherliga", "Frostmane", "Frostmourne", "Frostwhisper", "Frostwolf", "Galakrond", "Garona", "Garrosh", "Genjuros", "Ghostlands", "Gilneas", "Goldrinn", "Gordunni", "Gorgonnash", "Greymane", "Grim-Batol", "Grom", "Guldan", "Hakkar", "Haomarush", "Hellfire", "Hellscream", "Howling-Fjord", "Hyjal", "Illidan", "Jaedenar", "KaelThas", "Karazhan", "Kargath", "Kazzak", "KelThuzad", "Khadgar", "Khaz-Modan", "Khazgoroth", "Kiljaeden", "Kilrogg", "Kirin-Tor", "Korgall", "Kragjin", "Krasus", "Kul-Tiras", "Kult-der-Verdammten", "La-Croisade-Ecarlate", "Laughing-Skull", "Les-Clairvoyants", "Les-Sentinelles", "Lich-King", "Lightbringer", "Lightnings-Blade", "Lordaeron", "Los-Errantes", "Lothar", "Madmortem", "Magtheridon", "MalGanis", "Malfurion", "Malorne", "Malygos", "Mannoroth", "Marecage-de-Zangar", "Mazrigos", "Medivh", "Minahonda", "Moonglade", "Mugthol", "Nagrand", "Nathrezim", "Naxxramas", "Nazjatar", "Nefarian", "Nemesis", "Neptulon", "Nerzhul", "Nerathor", "Nethersturm", "Nordrassil", "Norgannon", "Nozdormu", "Onyxia", "Outland", "Perenolde", "Pozzo-Delleternita", "Proudmoore", "QuelThalas", "Ragnaros", "Rajaxx", "Rashgarroth", "Ravencrest", "Ravenholdt", "Razuvious", "Rexxar", "Runetotem", "Sanguino", "Sargeras", "Saurfang", "Scarshield-Legion", "Senjin", "Shadowsong", "Shattered-Halls", "Shattered-Hand", "Shattrath", "Shendralar", "Silvermoon", "Sinstralis", "Skullcrusher", "Soulflayer", "Spinebreaker", "Sporeggar", "Steamwheedle-Cartel", "Stormrage", "Stormreaver", "Stormscale", "Sunstrider", "Sylvanas", "Taerar", "Talnivarr", "Tarren-Mill", "Teldrassil", "Temple-Noir", "Terenas", "Terokkar", "Terrordar", "The-Maelstrom", "The-Shatar", "The-Venture-Co", "Theradras", "Thermaplugg", "Thrall", "ThrokFeroth", "Thunderhorn", "Tichondrius", "Tirion", "Todeswache", "Trollbane", "Turalyon", "Twilights-Hammer", "Twisting-Nether", "Tyrande", "Uldaman", "Ulduar", "Uldum", "UnGoro", "Varimathras", "Vashj", "Veklor", "Veknilash", "Voljin", "Wildhammer", "Wrathbringer", "Xavius", "Ysera", "Ysondre", "Zenedar", "Zirkel-des-Cenarius", "Zuljin", "Zuluhed"})
        Me.ComboBox2.Location = New System.Drawing.Point(18, 70)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(98, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(19, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Scan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button_Filter)
        Me.GroupBox2.Controls.Add(Me.Button_ClearFilter)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 112)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter by Itemname"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(19, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(98, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button_Filter
        '
        Me.Button_Filter.Enabled = False
        Me.Button_Filter.Location = New System.Drawing.Point(19, 55)
        Me.Button_Filter.Name = "Button_Filter"
        Me.Button_Filter.Size = New System.Drawing.Size(97, 23)
        Me.Button_Filter.TabIndex = 9
        Me.Button_Filter.Text = "filter"
        Me.Button_Filter.UseVisualStyleBackColor = True
        '
        'Button_ClearFilter
        '
        Me.Button_ClearFilter.Enabled = False
        Me.Button_ClearFilter.Location = New System.Drawing.Point(31, 84)
        Me.Button_ClearFilter.Name = "Button_ClearFilter"
        Me.Button_ClearFilter.Size = New System.Drawing.Size(73, 23)
        Me.Button_ClearFilter.TabIndex = 0
        Me.Button_ClearFilter.Text = "clear filter"
        Me.Button_ClearFilter.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(452, 535)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "get source"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(316, 463)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(374, 66)
        Me.TextBox2.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'ListView2
        '
        Me.ListView2.AutoArrange = False
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(366, 373)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(116, 72)
        Me.ListView2.TabIndex = 9
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Server"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item"
        Me.ColumnHeader2.Width = 262
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Current Bid"
        Me.ColumnHeader3.Width = 74
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Min. Bid"
        Me.ColumnHeader4.Width = 69
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Time Left"
        Me.ColumnHeader5.Width = 66
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "# Bids"
        Me.ColumnHeader6.Width = 58
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Realm Price"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Global Price"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Realm Qty."
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Last Updated"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 91
        '
        'ListView3
        '
        Me.ListView3.AutoArrange = False
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(525, 373)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(106, 72)
        Me.ListView3.TabIndex = 10
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Server"
        Me.ColumnHeader11.Width = 84
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Item"
        Me.ColumnHeader12.Width = 262
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Current Bid"
        Me.ColumnHeader13.Width = 74
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Min. Bid"
        Me.ColumnHeader14.Width = 69
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Time Left"
        Me.ColumnHeader15.Width = 66
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "# Bids"
        Me.ColumnHeader16.Width = 58
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Realm Price"
        Me.ColumnHeader17.Width = 0
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Global Price"
        Me.ColumnHeader18.Width = 100
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Realm Qty."
        Me.ColumnHeader19.Width = 0
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Last Updated"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader20.Width = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(363, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Backup"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(522, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Filter Selection"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 305)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(851, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(634, 17)
        Me.ToolStripStatusLabel2.Spring = True
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 16)
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(753, 463)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 327)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMAH Scanner v1.0.1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Server As ColumnHeader
    Friend WithEvents Item As ColumnHeader
    Friend WithEvents CurrentBid As ColumnHeader
    Friend WithEvents MinBid As ColumnHeader
    Friend WithEvents TimeLeft As ColumnHeader
    Friend WithEvents Bids As ColumnHeader
    Friend WithEvents RealmPrice As ColumnHeader
    Friend WithEvents GlobalPrice As ColumnHeader
    Friend WithEvents RealmQty As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button_ClearFilter As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button_Filter As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ListView3 As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents ItemID As ColumnHeader
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotxtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TocsvToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
End Class
