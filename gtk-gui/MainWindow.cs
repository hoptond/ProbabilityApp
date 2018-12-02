
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Frame frame1;

	private global::Gtk.VBox vbox4;

	private global::Gtk.VBox vbox7;

	private global::Gtk.Label label;

	private global::Gtk.VBox vbox5;

	private global::Gtk.Entry entry1;

	private global::Gtk.Entry entry2;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Button combineButton;

	private global::Gtk.Button eitherButton;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView outputView;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Probability App");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.frame1 = new global::Gtk.Frame();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.label = new global::Gtk.Label();
		this.label.Name = "label";
		this.label.LabelProp = global::Mono.Unix.Catalog.GetString("Enter your values below");
		this.vbox7.Add(this.label);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		this.vbox4.Add(this.vbox7);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox7]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.vbox5.Add(this.entry1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.entry1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.vbox5.Add(this.entry2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.entry2]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.combineButton = new global::Gtk.Button();
		this.combineButton.CanFocus = true;
		this.combineButton.Name = "combineButton";
		this.combineButton.UseUnderline = true;
		this.combineButton.Label = global::Mono.Unix.Catalog.GetString("Combine");
		this.hbox3.Add(this.combineButton);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.combineButton]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.eitherButton = new global::Gtk.Button();
		this.eitherButton.CanFocus = true;
		this.eitherButton.Name = "eitherButton";
		this.eitherButton.UseUnderline = true;
		this.eitherButton.Label = global::Mono.Unix.Catalog.GetString("Either");
		this.hbox3.Add(this.eitherButton);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.eitherButton]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		this.vbox5.Add(this.hbox3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox3]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox4.Add(this.vbox5);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vbox5]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.outputView = new global::Gtk.TextView();
		this.outputView.CanFocus = true;
		this.outputView.Name = "outputView";
		this.outputView.Editable = false;
		this.outputView.AcceptsTab = false;
		this.outputView.WrapMode = ((global::Gtk.WrapMode)(2));
		this.GtkScrolledWindow.Add(this.outputView);
		this.vbox4.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.GtkScrolledWindow]));
		w10.Position = 2;
		this.frame1.Add(this.vbox4);
		this.Add(this.frame1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.combineButton.Clicked += new global::System.EventHandler(this.CombineProbs);
		this.eitherButton.Clicked += new global::System.EventHandler(this.EitherProbs);
	}
}
