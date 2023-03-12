using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonEditor_form.models
{
    public class StringObject
    {
        private TreeNode node;

        public TreeNode Node
        {
            get { return node; }
            set { node = value; }
        }

        public StringObject(string nom, string value)
        {
            node = new TreeNode(nom)
            {
                Name= value
            };
        }
    }
}
