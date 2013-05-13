using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAX_Simulator
{
    public partial class MainWindow : Form
    {
        string[] _bruteReferences;
        List<Process> _references;
        int _numberOfFrames;
        int _algorithm; //1 -- Fifo, 2 -- LRU, 3 -- OPT
        int hd_writes, page_faults;
        List<Process> _memory;

        public MainWindow()
        {
            InitializeComponent();
            rdFifo.Select();
            rd10.Select();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(rd10.Checked)
                _numberOfFrames = 10;
            if(rd50.Checked)
                _numberOfFrames = 50;
            if(rd100.Checked)
                _numberOfFrames = 100;
            

            var ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();
            _references = new List<Process>();
            if (result == DialogResult.OK)
            {
                _bruteReferences = File.ReadAllLines(ofd.FileName);
                //Lectura de todas las lineas del achivo transformadas a referencias de memoria (para futuros usos)
                for (int i = 0; i < _bruteReferences.Count(); i++)
                {
                    string adress = _bruteReferences[i].Split(' ')[0];
                    string action = _bruteReferences[i].Split(' ')[1];
                    _references.Add(new Process(adress, action));
                }

                if (rdFifo.Checked)
                    Fifo();
                if (rdLru.Checked)
                    LRU();
                if (rdOpt.Checked)
                    _algorithm = 3;

                txtOutput.Text = "";
                txtOutput.AppendText("Page faults: " + page_faults + "\r\n" +
                                     "Hard Drive Writes: " + hd_writes + "\r\n");
            }
            else
            {
                _bruteReferences = new string[0];
            }

            
        }

      

        public void Fifo()
        {
            hd_writes = 0;
            page_faults = 0;
            _memory = new List<Process>();
            for (int i = 0; i < _references.Count; i++)
            {
                if (_memory.Count() < _numberOfFrames - 1)
                {
                    if (Search(_memory, _references[i]) == -1)
                    {
                        _memory.Add(_references[i]);
                    }
                }
                else
                {
                    if (Search(_memory, _references[i]) == -1)
                    {
                        if (_memory[0]._action.Equals("W"))
                            hd_writes++;
                        _memory.RemoveAt(0);
                        _memory.Add(_references[i]);
                        page_faults++;
                    }
                }
            }
         }

        public void LRU()
        {
            hd_writes = 0;
            page_faults = 0;
            _memory = new List<Process>();
            for (int i = 0; i < _references.Count; i++)
            {
                if (_memory.Count() < _numberOfFrames - 1)
                {
                    
                    int index = Search(_memory, _references[i]);
                    if (index == -1)
                    {
                        increaseUse();
                        _memory.Add(_references[i]);
                        
                    }else
                    {
                        increaseUse();
                        _memory[index].use = 0;
                    }
                }
                else
                {
                    int index = Search(_memory, _references[i]);
                    if (index == -1)
                    {
                        int lru = getLessRecentUse();
                       // Console.WriteLine(_memory[lru]._action + "----" + _memory[lru]._adress);
                        if (_memory[lru]._action.Equals("W"))
                            hd_writes++;

                        _memory.RemoveAt(lru);
                        _memory.Insert(lru, _references[i]);
                        increaseUse();
                        page_faults++;
                    }else
                    {
                        increaseUse();
                        _memory[index].use = 0;
                    }
                }
            }
        }

        public void increaseUse()
        {
            for (int i = 0; i < _memory.Count; i++)
            {
                _memory[i].use++;
            }
        }

        public int getLessRecentUse()
        {
            int lru = 0;
            for (int i = 1; i < _memory.Count; i++)
            {
                if (_memory[i].use > _memory[lru].use)
                    lru = i;
            }
            return lru;
        }


        public int Search(List<Process> memory, Process value)
        {
            for (int i = 0; i < memory.Count(); i++)
            {
                if (memory[i]._adress.Equals(value._adress))
                    return i;
            }
            return -1;
        }
    }
}
