using BinaryTreeApp.Data_Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BinaryTreeApp.APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mainPage : ContentPage
    {
        public mainPage()
        {
            InitializeComponent();
        }

        
        public void Add(object sender, EventArgs e)
        {
            if (newNode.Text != null)
            {
                BinarySearchTree.Add(int.Parse(newNode.Text));
                tree.Text = BinarySearchTree.toString();
            }
        }
        
        public void Pre(object sender, EventArgs e)
        {
            Order.Text = BinarySearchTree.TraversePreOrder();
        }


        public void In(object sender, EventArgs e)
        {
            Order.Text = BinarySearchTree.TraverseInOrder();
        }

        public void Post(object sender, EventArgs e)
        {
            Order.Text = BinarySearchTree.TraversePostOrder();

        }

        public void Clear(object sender, EventArgs e)
        {
            BinarySearchTree.clear();
            tree.Text = "ADD A NODE";
            Order.Text = "YOUR ORDER OUTPUT";
        }
    }
}