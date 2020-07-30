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
        /// <summary>
        /// Constructor()
        /// </summary>
        public mainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calls the Add method from the BinarySearchTree class and executes the tree printing to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Add(object sender, EventArgs e)
        {
            if (newNode.Text != null)
            {
                BinarySearchTree.Add(int.Parse(newNode.Text));
                tree.Text = BinarySearchTree.toString();
            }
        }
        /// <summary>
        /// Takes the output label and prints the pre-order traverse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Pre(object sender, EventArgs e)
        {
            Order.Text = BinarySearchTree.TraversePreOrder();
        }
        /// <summary>
        /// Takes the output label and prints the in-order traverse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void In(object sender, EventArgs e)
        {
            Order.Text = BinarySearchTree.TraverseInOrder();
        }
        /// <summary>
        /// Takes the output label and prints the post-order traverse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Post(object sender, EventArgs e)
        {
            Order.Text = BinarySearchTree.TraversePostOrder();

        }
        /// <summary>
        /// Clears the tree and resets all labels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Clear(object sender, EventArgs e)
        {
            BinarySearchTree.Clear();
            tree.Text = "YOUR TREE DISPLAY";
            Order.Text = "YOUR ORDER OUTPUT";
        }
    }
}