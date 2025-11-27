using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class Tarefa
    {
        private int _id;
        private string _titulo = "";
        private string _descricao = "";
        private bool _status;
        private DateTime _data;

        public Tarefa(DateTime data, bool status)
        {
            this._data = data;
            this._status = status;
        }

        public int Id
        {
            get => _id; 
            set => _id = value;
        }

        public string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }

        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        public bool Status
        {
            get => _status;
            set => _status = value;
        }

        public DateTime Data
        {
            get { return _data; }
        }
        
    }
}
