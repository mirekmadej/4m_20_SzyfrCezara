namespace _4m_20_SzyfrCezara
{

    public partial class MainPage : ContentPage
    {
        string tj1 = "";
        string tz1 = "";
        int p1 = 3;

        public MainPage()
        {
            InitializeComponent();
        }
        private void btnZaszyfrujClicked(object sender, EventArgs e)
        {
            tz1 = "";
            tj1 = entJawny1.Text.ToUpper();
            p1 = int.Parse(entPrzesuniecie1.Text);
            foreach( char c in tj1 )
            {
                if (c >= 'A' && c <= 'Z')
                {
                    int z = (int)(c) + p1;
                    if (z > (int)('Z'))
                        z = z - ((int)('Z') - (int)'A' + 1);
                    tz1 += (char)z;
                }
                else
                    tz1 += c;
            }                        
            lblZaszyfr1.Text = tz1;
        }
        private void btnOdszyfrujClicked( object sender, EventArgs e )
        {
            string tj2 = "";
            string tz1 = entZaszyfrowany2.Text.ToUpper();
            int p2 = int.Parse(entPrzesuniecie2.Text);
            foreach (char c in tz1)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    int z = (int)(c) - p2;
                    if (z < (int)('A'))
                        z = z + ((int)('Z') - (int)'A' + 1);
                    tj2 += (char)z;
                }
                else
                    tj2 += c;
            }
            lblJawny2.Text = tj2;
        }


    }
}