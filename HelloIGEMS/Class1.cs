using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HelloIGEMS
{
    public class Hello
    {
        public static void DLLMain()
        {
            string name = Interaction.InputBox(
                "What is your name?",
                "Name Input",
                "Ryan"
            );

            MessageBox.Show("Hello " + name + "!");
        }
    }
}
