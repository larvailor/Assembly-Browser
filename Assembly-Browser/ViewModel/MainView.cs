using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Reflection;
using Model;
using Model.Assembly;
using Model.Assembly.Namespace;
using System.Collections.ObjectModel;
using Model.Assembly.Namespace.Types;
using System.Windows;
using Microsoft.Win32;

namespace ViewModel
{
    public class MainView : INotifyPropertyChanged
    {
        // variables
        public event PropertyChangedEventHandler PropertyChanged;
        private AssemblyBrowser assembly;
        private ObservableCollection<TreeNode> _nodes;
        public ObservableCollection<TreeNode> Nodes
        {
            get { return _nodes; }
            set
            {
                _nodes = value;
                OnPropertyChanged();
            }
        }

            

        // methods
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }



        private ObservableCollection<TreeNode> NamespacesToObservableCollection(Dictionary<string, ExportedNsInfo> namespaces)
        {
            var collection = new ObservableCollection<TreeNode>();
            foreach (var ns in namespaces)
            {
                collection.Add(new TreeNode(ns.Value.ToString(), TypesToObservableCollection(ns.Value.Types)));
            }
            return collection;
        }



        private ObservableCollection<TreeNode> TypesToObservableCollection(List<ExportedTypeInfo> types)
        {
            var collection = new ObservableCollection<TreeNode>();
            foreach (var type in types)
            {
                collection.Add(new TreeNode(type.ToString(), TypeMembersToObservableCollection(type)));
            }
            return collection;
        }



        private ObservableCollection<TreeNode> TypeMembersToObservableCollection(ExportedTypeInfo type)
        {
            var collection = new ObservableCollection<TreeNode>();
            foreach (var field in type.Fields)
            {
                collection.Add(new TreeNode(field.ToString()));
            }

            foreach (var property in type.Properties)
            {
                collection.Add(new TreeNode(property.ToString()));
            }

            foreach (var method in type.Methods)
            {
                collection.Add(new TreeNode(method.ToString()));
            }

            return collection;
        }



        public void LoadAssembly(object o, RoutedEventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Filter += "Dll files(*.dll)|*.dll";
            if (fileDialog.ShowDialog() == false)
                return;
            assembly = AssemblyLoader.Load(fileDialog.FileName);
            Nodes = new ObservableCollection<TreeNode>
            {
                new TreeNode(assembly.ToString(), NamespacesToObservableCollection(assembly.Namespaces))
            };
        }
    }
}
