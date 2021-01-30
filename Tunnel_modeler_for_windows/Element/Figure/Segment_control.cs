using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modeler.Tunnel.Windows.Segment;

namespace Modeler.Tunnel.Windows.Element.Figure
{
    public partial class Segment_control : UserControl
    {
        public const int resource_size_const = 32;
        public const int circle_size_const = 4;
        public const int devider = 8;
        Segment_specification configuration = new Segment_specification();
        Resource_enum resource;
        Direction_enum direction;
        Period_enum period;
        Abstraction_enum abstraction;
        Decision_enum decision;
        Group_enum group;

        int actual_width;
        int actual_height;
        int actual_field;
        int resource_top;

        Pen line_pen;
        Brush foreground_brush;

        public Segment_control()
        {
            InitializeComponent();
        }

        private void Segment_control_Paint(object sender, PaintEventArgs e)
        {
            actual_width = this.ClientRectangle.Width - circle_size_const;
            actual_height = this.ClientRectangle.Height - resource_size_const;
            actual_field = Math.Max(Math.Min(actual_width, actual_height) / devider + 1, 5);
            resource_top = ClientRectangle.Top + actual_height;

            line_pen = Pens.Black;
            foreground_brush = Brushes.White;

            Rectangle rect = new Rectangle(this.ClientRectangle.X, this.ClientRectangle.Y,
                actual_width - circle_size_const, actual_height);
            e.Graphics.FillRectangle(foreground_brush, rect);
            e.Graphics.DrawRectangle(line_pen, rect);
            Draw_direction(e.Graphics);
            Draw_decision(e.Graphics);
            Draw_level(e.Graphics);
            Draw_resource(e.Graphics);
        }

        private void инициацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            period = Period_enum.Initiation_period;
            Update_checking();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Update_checking();
        }

        private void Update_checking()
        {
            абстрактноеToolStripMenuItem.Checked = (abstraction == Abstraction_enum.Abstract_abstraction);
            конкретноеToolStripMenuItem.Checked = (abstraction == Abstraction_enum.Nature_abstraction);

            инициацияToolStripMenuItem.Checked = (period == Period_enum.Initiation_period);
            развитиеToolStripMenuItem.Checked = (period == Period_enum.Development_period);
            стабилизацияToolStripMenuItem.Checked = (period == Period_enum.Stabilization_period);
            консервацияToolStripMenuItem.Checked = (period == Period_enum.Preservation_period);

            пустотаToolStripMenuItem.Checked = (group == Group_enum.Empty_group);
            фракталыToolStripMenuItem.Checked = (group == Group_enum.Fractal_group);
            энергияToolStripMenuItem.Checked = (group == Group_enum.Energy_group);
            информацияToolStripMenuItem.Checked = (group == Group_enum.Information_group);
            статикаToolStripMenuItem.Checked = (group == Group_enum.Elemental_group);
            динамикаToolStripMenuItem.Checked = (group == Group_enum.Process_group);
            синергетикаToolStripMenuItem.Checked = (group == Group_enum.Synergic_group);
            бюрократияToolStripMenuItem.Checked = (group == Group_enum.Bureaucratic_group);
            экологияToolStripMenuItem.Checked = (group == Group_enum.Ecology_group);
            космосToolStripMenuItem.Checked = (group == Group_enum.Cosmic_group);

            Act_ToolStripMenuItem1.Checked = (direction == Direction_enum.Act_direction);
            Plan_ToolStripMenuItem.Checked = (direction == Direction_enum.Plan_direction);
            Do_ToolStripMenuItem.Checked = (direction == Direction_enum.Do_direction);
            Check_ToolStripMenuItem.Checked = (direction == Direction_enum.Check_direction);

            энергияToolStripMenuItem1.Checked = (resource & Resource_enum.energe_resource) != 0;
            силаToolStripMenuItem.Checked = (resource & Resource_enum.force_resource) != 0;
            пространствоToolStripMenuItem.Checked = (resource & Resource_enum.space_resource) != 0;
            времяToolStripMenuItem.Checked = (resource & Resource_enum.time_resource) != 0;
            сообщениеToolStripMenuItem.Checked = (resource & Resource_enum.message_resource) != 0;
            оборудованиеToolStripMenuItem.Checked = (resource & Resource_enum.equipment_resource) != 0;
            причинаToolStripMenuItem.Checked = (resource & Resource_enum.cause_resource) != 0;
            величинаToolStripMenuItem.Checked = (resource & Resource_enum.force_resource) != 0;
            способToolStripMenuItem.Checked = (resource & Resource_enum.method_resource) != 0;
            мотивацияToolStripMenuItem.Checked = (resource & Resource_enum.motivation_resource) != 0;
            вниманиеToolStripMenuItem.Checked = (resource & Resource_enum.attention_resource) != 0;
            this.Invalidate();
        }

        private void экологияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Ecology_group;
            Update_checking();
        }

        private void бюрократияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Bureaucratic_group;
            Update_checking();
        }

        private void синергетикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Synergic_group;
            Update_checking();
        }

        private void динамикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Process_group;
            Update_checking();
        }

        private void статикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Elemental_group;
            Update_checking();
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Information_group;
            Update_checking();
        }

        private void энергияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Energy_group;
            Update_checking();
        }

        private void консервацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            period = Period_enum.Preservation_period;
            Update_checking();
        }

        private void стабилизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            period = Period_enum.Stabilization_period;
            Update_checking();
        }

        private void развитиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            period = Period_enum.Development_period;
            Update_checking();
        }

        private void выборToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (decision == Decision_enum.Select_decision)

            {

                decision = Decision_enum.Unknown_decision;
            }
            else
            {
                decision = Decision_enum.Select_decision;
            }
            Update_checking();
        }

        private void циклToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (decision == Decision_enum.Cycle_decision)
                decision = Decision_enum.Unknown_decision;
            else
                decision = Decision_enum.Cycle_decision;
            Update_checking();
        }

        private void сбросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = Direction_enum.Unknown_direction;
            abstraction = Abstraction_enum.Unknown_abstraction;
            group = Group_enum.Unknown_group;
            period = Period_enum.Unknown_period;
            decision = Decision_enum.Unknown_decision;
            Update_checking();
        }

        private void пToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Check_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = Direction_enum.Check_direction;
            Update_checking();
        }

        private void Do_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = Direction_enum.Do_direction;
            Update_checking();
        }

        private void Plan_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = Direction_enum.Plan_direction;
            Update_checking();
        }

        private void Act_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            direction = Direction_enum.Act_direction;
            Update_checking();
        }

        private void абстрактноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abstraction = Abstraction_enum.Abstract_abstraction;
            Update_checking();
        }

        private void конкретноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abstraction = Abstraction_enum.Nature_abstraction;
            Update_checking();
        }

        private void энергияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resource ^= Resource_enum.energe_resource;
            энергияToolStripMenuItem1.Checked = (resource & Resource_enum.energe_resource) != 0;

        }

        private void силаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resource ^= Resource_enum.force_resource;
            силаToolStripMenuItem.Checked = (resource & Resource_enum.force_resource) != 0;
        }

        private void пространствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resource ^= Resource_enum.space_resource;
            пространствоToolStripMenuItem.Checked = (resource & Resource_enum.space_resource) != 0;
        }

        private void времяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resource ^= Resource_enum.time_resource;
            времяToolStripMenuItem.Checked = (resource & Resource_enum.time_resource) != 0;
        }

        private void сообщениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resource ^= Resource_enum.message_resource;
            сообщениеToolStripMenuItem.Checked = (resource & Resource_enum.message_resource) != 0;
        }

        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resource ^= Resource_enum.equipment_resource;
            оборудованиеToolStripMenuItem.Checked = (resource & Resource_enum.equipment_resource) != 0;
        }

        private void причинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resource ^= Resource_enum.cause_resource;
            причинаToolStripMenuItem.Checked = (resource & Resource_enum.cause_resource) != 0;
        }

        private void величинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resource ^= Resource_enum.force_resource;
            величинаToolStripMenuItem.Checked = (resource & Resource_enum.force_resource) != 0;
        }

        private void Segment_control_Load(object sender, EventArgs e)
        {

        }
        
        private void Draw_direction(Graphics g)
        {
            Pen pen = Pens.Black;
            int x = this.ClientRectangle.X + actual_width - circle_size_const - actual_field;
            switch (direction)
            {
                case Direction_enum.Act_direction:
                    g.DrawLine(pen
                        , x
                        , this.ClientRectangle.Y
                        , x
                        , this.ClientRectangle.Y + actual_height);
                    break;
                case Direction_enum.Plan_direction:
                    g.DrawLine(pen
                        , x
                        , this.ClientRectangle.Y
                        , x
                        , this.ClientRectangle.Y + actual_height / 2 - actual_field);
                    g.DrawLine(pen
                        , x
                        , this.ClientRectangle.Y + actual_height / 2 - actual_field
                        , this.ClientRectangle.X + actual_width - circle_size_const
                        , this.ClientRectangle.Y + actual_height / 2);
                    g.DrawLine(pen
                        , this.ClientRectangle.X + actual_width - circle_size_const
                        , this.ClientRectangle.Y + actual_height / 2
                        , x
                        , this.ClientRectangle.Y + actual_height / 2 + actual_field);
                    g.DrawLine(pen
                        , x
                        , this.ClientRectangle.Y + actual_height / 2 + actual_field
                        , x
                        , this.ClientRectangle.Y + actual_height);
                    break;
                case Direction_enum.Do_direction:
                    g.DrawLine(pen
                        , x
                        , this.ClientRectangle.Y
                        , this.ClientRectangle.X + actual_width - circle_size_const
                        , this.ClientRectangle.Y + actual_height / 2);
                    g.DrawLine(pen
                        , this.ClientRectangle.X + actual_width - circle_size_const
                        , this.ClientRectangle.Y + actual_height / 2
                        , x
                        , this.ClientRectangle.Y + actual_height);
                    break;
                case Direction_enum.Check_direction:
                    g.DrawLine(pen
                        , x
                        , this.ClientRectangle.Y
                        , this.ClientRectangle.X + actual_width - circle_size_const
                        , this.ClientRectangle.Y + actual_field);
                    g.DrawLine(pen
                        , this.ClientRectangle.X + actual_width - circle_size_const
                        , this.ClientRectangle.Y + actual_height - actual_field
                        , x
                        , this.ClientRectangle.Y + actual_height);
                    break;
            }
        }

        private void Draw_decision(Graphics g)
        {
            if (decision == Decision_enum.Cycle_decision || decision == Decision_enum.Select_decision)
            {
                g.FillEllipse(Brushes.White
                    , this.ClientRectangle.X + actual_width - circle_size_const * 2
                    , this.ClientRectangle.Y + actual_height - actual_field - circle_size_const
                    , circle_size_const * 2
                    , circle_size_const * 2);
                g.DrawEllipse(Pens.Black
                    , this.ClientRectangle.X + actual_width - circle_size_const *2
                    , this.ClientRectangle.Y + actual_height - actual_field - circle_size_const
                    , circle_size_const * 2
                    , circle_size_const * 2);
            }
        }

        private void Draw_level(Graphics g)
        {


        }
        private Rectangle Resource_rectangle(int resource_number)
        {

            Rectangle r = new Rectangle();
            r.X = resource_size_const * resource_number;
            r.Y = ClientRectangle.Height - resource_size_const;
            r.Width = resource_size_const;
            r.Height = resource_size_const - 1;
            return r;
        }

        private void Draw_resource(Graphics g)
        {
            int resource_count = 0;
            Rectangle r0;
 

            if ((resource & Resource_enum.attention_resource) != 0)
            {
                r0 = Resource_rectangle(resource_count);
                g.FillRectangle(foreground_brush, r0);
                g.DrawRectangle(line_pen, r0);

                r0.Y += 4;
                r0.X += 4;
                r0.Height -= 8;
                r0.Width -= 8;
                g.DrawEllipse(line_pen, r0);

                r0.Y += 4;
                r0.X += 4;
                r0.Height -= 8;
                r0.Width -= 8;
                g.DrawEllipse(line_pen, r0);
                ++resource_count;
            }

            if ((resource & Resource_enum.energe_resource) != 0)
            {
                r0 = Resource_rectangle(resource_count);
                
                g.FillRectangle(foreground_brush, r0);
                g.DrawRectangle(line_pen, r0);

                g.DrawArc(line_pen, r0.X, r0.Y + r0.Height/2, r0.Width / 2, r0.Height, 0, 180);
                g.DrawArc(line_pen, r0.X + r0.Width / 2, r0.Y - r0.Height, r0.Width / 2, r0.Height, -180, 0);

                ++resource_count;
            }

        }

        private void вниманиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((resource & Resource_enum.attention_resource) == 0)
                resource |= Resource_enum.attention_resource;
            else
                resource &= ~Resource_enum.attention_resource;
        }

        private void космосToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Cosmic_group;
            Update_checking();

        }

        private void фракталыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Fractal_group;
            Update_checking();
        }

        private void пустотаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group = Group_enum.Empty_group;
            Update_checking();
        }

        private void InitializeComponent_rezerv()
        {
            this.SuspendLayout();
            // 
            // Segment_control
            // 
            this.Name = "Segment_control";
            this.Size = new System.Drawing.Size(150, 114);
            this.ResumeLayout(false);

        }
    }
}
