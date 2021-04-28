using System;
using System.Windows.Forms;

namespace Practic6
{
    public partial class MainForm : Form
    {
        private int N, k, l, m, v, b, d;

        private int count = 0, iter = 0;
        private bool CPU, HDD, NET;
        private Random rnd = new Random();
        private ProcessData[] processData;
        private ProcessData currentProcessCPU = null, currentProcessHDD = null, currentProcessNET = null;

        private void modelingB_Click(object sender, EventArgs e)
        {
            N = (int)nNumeric.Value;
            k = (int)kNumeric.Value;
            l = (int)lNumeric.Value;
            m = (int)mNumeric.Value;
            v = (int)vNumeric.Value;
            b = (int)bNumeric.Value;
            d = (int)dNumeric.Value;
            CPU = true;
            HDD = true;
            NET = true;
            processData = new ProcessData[N];
            dataGridView.Rows.Clear();
            listBox.Items.Clear();
            // Заполнение массива задач
            for (int i = 0; i < N; i++)
            {
                processData[i] = new ProcessData();
                processData[i].name = i.ToString();
                processData[i].tCPU = k + rnd.Next(-l, l);
                processData[i].tHDD = m + rnd.Next(-v, v);
                processData[i].tNET = b + rnd.Next(-d, d);
                processData[i].step = 0;
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells["CName"].Value = processData[i].name;
                dataGridView.Rows[i].Cells["CCPU"].Value = processData[i].tCPU;
                dataGridView.Rows[i].Cells["CHDD"].Value = processData[i].tHDD;
                dataGridView.Rows[i].Cells["CNET"].Value = processData[i].tNET;
            }

            double time = 0d;
            double old_time = 0d;
            double deltaTime = 0d;
            double processedTimeCPU = 0d;
            double processedTimeHDD = 0d;
            double processedTimeNET = 0d;
            // Пока все задачи не выполнены (задача выполнена, когда она обработается на сетевой карте)
            while (count < N)
            {
                // Если процессор проставивает
                if (CPU)
                {
                    CPU = false;
                    sortBy(ref processData, 1);
                    foreach (var process in processData)
                    {
                        if (process.step == 0)
                        {
                            currentProcessCPU = process;
                            break;
                        }
                    }
                    if (currentProcessCPU == null)
                        CPU = true;
                }
                // Если жёсткий диск простаивает
                if (HDD)
                {
                    HDD = false;
                    sortBy(ref processData, 2);
                    foreach (var process in processData)
                    {
                        if (process.step == 1)
                        {
                            currentProcessHDD = process;
                            break;
                        }
                    }
                    if (currentProcessHDD == null)
                        HDD = true;
                }
                // Если сетевая карта простаивает
                if (NET)
                {
                    NET = false;
                    sortBy(ref processData, 3);
                    foreach (var process in processData)
                    {
                        if (process.step == 2)
                        {
                            currentProcessNET = process;
                            break;
                        }
                    }
                    if (currentProcessNET == null)
                        NET = true;
                }
                iter++;

                // Минимальное изменение времени
                deltaTime = Math.Min(Math.Min(currentProcessCPU?.tCPU ?? double.MaxValue, currentProcessHDD?.tHDD ?? double.MaxValue), currentProcessNET?.tNET ?? double.MaxValue);

                old_time = time;
                time += deltaTime;

                listBox.Items.Add("Итерация №" + iter + ": " + "CPU - " + currentProcessCPU?.name + "; HDD - " + currentProcessHDD?.name + "; NET - " + currentProcessNET?.name);
                // Выполняется ли какая-нибудь задача на процессоре
                if (currentProcessCPU != null)
                {
                    // Если процессор успевает обработать задачу
                    if (currentProcessCPU.tCPU + old_time - processedTimeCPU <= time)
                    {
                        CPU = true;
                        currentProcessCPU.step = 1;
                        currentProcessCPU = null;
                        processedTimeCPU = 0d;
                    }
                    else
                        processedTimeCPU += deltaTime;
                }
                // Выполняется ли какая-нибудь задача на жёстком диске
                if (currentProcessHDD != null)
                {
                    // Если жёсткий диск успевает обрабоать задачу
                    if (currentProcessHDD.tHDD + old_time - processedTimeHDD <= time)
                    {
                        HDD = true;
                        currentProcessHDD.step = 2;
                        currentProcessHDD = null;
                        processedTimeHDD = 0d;
                    }
                    else
                        processedTimeHDD += deltaTime;
                }
                // Выполняется ли какая-нибудь задача на сетевой карте
                if (currentProcessNET != null)
                {
                    // Если сетевая карта успевает обработать задачу
                    if (currentProcessNET.tNET + old_time - processedTimeNET <= time)
                    {
                        NET = true;
                        currentProcessNET.step = 3;
                        currentProcessNET = null;
                        processedTimeNET = 0d;
                        count++;
                    }
                    else
                    {
                        processedTimeNET += deltaTime;
                    }
                }
            }
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void sortBy(ref ProcessData[] data, byte param)
        {
            ProcessData temp;
            if (param == 1)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = i; j < data.Length; j++)
                    {
                        if (data[i].tCPU < data[j].tCPU)
                        {
                            temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
            }
            else if (param == 2)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = i; j < data.Length; j++)
                    {
                        if (data[i].tHDD < data[j].tHDD)
                        {
                            temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = i; j < data.Length; j++)
                    {
                        if (data[i].tNET < data[j].tNET)
                        {
                            temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
                    }
                }
            }
        }
    }

    class ProcessData
    {
        public int tCPU;
        public int tHDD;
        public int tNET;
        public int step;
        public string name;
    }
}
