using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_UndoRedo
    {
        private List<Taladro> _taladro;
        private Stack<List<Taladro>> _stackUndoTaldro;
        private Stack<List<Taladro>> _stackRedoTaldro;

        public N_UndoRedo()
        {
            Taladro = new List<Taladro>();
            StackUndoTaldro = new Stack<List<Taladro>>();
            StackRedoTaldro = new Stack<List<Taladro>>();
            //UndoRedo(Taladro);
        }

        public List<Taladro> Taladro { get => _taladro; set => _taladro = value; }
        public Stack<List<Taladro>> StackUndoTaldro { get => _stackUndoTaldro; set => _stackUndoTaldro = value; }
        public Stack<List<Taladro>> StackRedoTaldro { get => _stackRedoTaldro; set => _stackRedoTaldro = value; }

        public void UndoRedo(List<Taladro> taladro)
        {
            Stack<List<Taladro>> _stackUndoTaldro = StackUndoTaldro;
            var _taladro = (from t in taladro select t).ToList();
            _stackUndoTaldro.Push(_taladro);
            StackUndoTaldro = _stackUndoTaldro;
            StackRedoTaldro = new Stack<List<Taladro>>();
            Taladro = _taladro;
        }

        public void Undo()
        {
            UndoTaladro();
        }

        public void Redo()
        {
            RedoTaladro();
        }

        private void UndoTaladro()
        {
            Stack<List<Taladro>> _stackUndoTaldro = StackUndoTaldro;
            Stack<List<Taladro>> _stackRedoTaldro = StackRedoTaldro;
            if (_stackUndoTaldro.Count > 0)
            {
                _stackRedoTaldro.Push(_stackUndoTaldro.Pop());                
                if (_stackUndoTaldro.Count == 0)
                {
                    Taladro = new List<Taladro>();
                    _stackUndoTaldro = new Stack<List<Taladro>>();
                }
                else
                {
                    Taladro = _stackUndoTaldro.Peek();
                }
                StackUndoTaldro = _stackUndoTaldro;
                StackRedoTaldro = _stackRedoTaldro;
            }
            
        }

        private void RedoTaladro()
        {
            Stack<List<Taladro>> _stackRedoTaldro = StackRedoTaldro;
            Stack<List<Taladro>> _stackUndoTaldro = StackUndoTaldro;
            if (_stackRedoTaldro.Count > 0)
            {
                _stackUndoTaldro.Push(_stackRedoTaldro.Pop());
                Taladro = _stackUndoTaldro.Peek();
                if (_stackRedoTaldro.Count == 0)
                {
                    _stackRedoTaldro = new Stack<List<Taladro>>();
                }
                StackRedoTaldro = _stackRedoTaldro;
                StackUndoTaldro = _stackUndoTaldro;
            }

        }
    }
}
