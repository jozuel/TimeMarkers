using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;
namespace TimeMarkers
{
    class KeyReader
    {
        private IKeyboardMouseEvents gloobalHook;

        public void Subscribe()
        {
            gloobalHook = Hook.GlobalEvents();

            //gloobalHook.KeyPress += GlobalHookKeyPress;
            gloobalHook.MouseDownExt += GlobalHookMouseDownExt;
            gloobalHook.KeyDown += GlobalHookKeyPress;
        }
        private void GlobalHookKeyPress(object sender, KeyEventArgs e)
        {
            MessageBox.Show("You press " + e.KeyCode + " key", "test", MessageBoxButtons.OK);
        }
        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("You press " + e.KeyChar + " key", "test", MessageBoxButtons.OK);
        }
        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
                MessageBox.Show("You press " + e.Button + " key", "test", MessageBoxButtons.OK);
        }

        public void Unsubscribe()
        {
            gloobalHook.KeyDown -= GlobalHookKeyPress;
            gloobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            //It is recommened to dispose it
            gloobalHook.Dispose();
        }
    }
}
