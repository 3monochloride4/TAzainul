using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace informasi_film
{
    public partial class Form1 : Form
    {
        datafilm film = new datafilm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            film.setrating((float)6.7);
            float ratingI = film.getrating();
            Rating1.Text = ratingI.ToString()+"/10";
            film.setrating(37);
            float ratingII = film.getrating();
            Rating2.Text = ratingII.ToString()+"%";
            film.setgenre("Adventure, Family, Fantasy");
            Genre.Text = film.getgenre();
            film.setsynopsis("In an effort to thwart Grindelwald's plans of raising pure-blood wizards to rule over all non-magical beings, Albus Dumbledore enlists his former student Newt Scamander, who agrees to help, though he's unaware of the dangers that lie ahead. Lines are drawn as love and loyalty are tested, even among the truest friends and family, in an increasingly divided wizarding world.");
            Synopsis.Text = film.getsynopsis();
            pb1.ImageLocation = "C:/Users/asus/Pictures/fantasticbeastposter.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            film.setrating((float)8.8);
            float ratingI = film.getrating();
            Rating1.Text = ratingI.ToString() + "/10";
            film.setrating(86);
            float ratingII = film.getrating();
            Rating2.Text = ratingII.ToString() + "%";
            film.setgenre("Action, Adventure, Sci-Fi ");
            Genre.Text = film.getgenre();
            film.setsynopsis("Dom Cobb is a skilled thief, the absolute best in the dangerous art of extraction, stealing valuable secrets from deep within the subconscious during the dream state, when the mind is at its most vulnerable. Cobb's rare ability has made him a coveted player in this treacherous new world of corporate espionage, but it has also made him an international fugitive and cost him everything he has ever loved. Now Cobb is being offered a chance at redemption. One last job could give him his life back but only if he can accomplish the impossible, inception. Instead of the perfect heist, Cobb and his team of specialists have to pull off the reverse: their task is not to steal an idea, but to plant one. If they succeed, it could be the perfect crime. But no amount of careful planning or expertise can prepare the team for the dangerous enemy that seems to predict their every move. An enemy that only Cobb could have seen coming.");
            Synopsis.Text = film.getsynopsis();
            pb1.ImageLocation = "C:/Users/asus/Pictures/inceptionposter6.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            film.setrating((float)7.3);
            float ratingI = film.getrating();
            Rating1.Text = ratingI.ToString() + "/10";
            film.setrating(94);
            float ratingII = film.getrating();
            Rating2.Text = ratingII.ToString() + "%";
            film.setgenre("Horror, Thriller");
            Genre.Text = film.getgenre();
            film.setsynopsis("In order to get away from their busy lives, the Wilson family takes a vacation to Santa Cruz, California with the plan of spending time with their friends, the Tyler family. On a day at the beach, their young son Jason almost wanders off, causing his mother Adelaide to become protective of her family. That night, four mysterious people break into Adelaide's childhood home where they're staying. The family is shocked to find out that the intruders look like them, only with grotesque appearances.");
            Synopsis.Text = film.getsynopsis();
            pb1.ImageLocation = "C:/Users/asus/Pictures/USposter.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            film.setrating((float)8.8);
            float ratingI = film.getrating();
            Rating1.Text = ratingI.ToString() + "/10";
            film.setrating(94);
            float ratingII = film.getrating();
            Rating2.Text = ratingII.ToString() + "%";
            film.setgenre("Action, Adventure, Sci-Fi");
            Genre.Text = film.getgenre();
            film.setsynopsis("After the devastating events of Avengers: Infinity War (2018), the universe is in ruins. With the help of remaining allies, the Avengers assemble once more in order to undo Thanos' actions and restore order to the universe. ");
            Synopsis.Text = film.getsynopsis();
            pb1.ImageLocation = "C:/Users/asus/Pictures/engameposter.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            film.setrating((float)6.1);
            float ratingI = film.getrating();
            Rating1.Text = ratingI.ToString() + "/10";
            film.setrating(26);
            float ratingII = film.getrating();
            Rating2.Text = ratingII.ToString() + "%";
            film.setgenre("Action, Adventure, Fantasy");
            Genre.Text = film.getgenre();
            film.setsynopsis("Based on the Bestselling book by Philip Reeve, Mortal Engines tells the story of a dystopian future, where cities move on wheels across a barren earth. One day on London, a young, scarred girl named Hester Shaw meets with a boy named Tom Natsworthy, an outcast from London, and accompanied by the brave Anti-Traction League, must stop the villainous Valentine and an unfolding plot to destroy the world.");
            Synopsis.Text = film.getsynopsis();
            pb1.ImageLocation = "C:/Users/asus/Pictures/mortalenginesposter.jpg";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
