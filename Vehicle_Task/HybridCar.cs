using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_educational_project.Vehicle_Task
{
    // НАСЛЕДНИК 3 (Дополнительный класс для быстрой практики)
    class HybridCar
    {
        public HybridCar(string model) : base(model) { }

        // TODO: Переопредели метод StartEngine так, чтобы он:
        // 1. Сначала вызвал базовый метод родителя (вывел "Двигатель заведен.")
        // 2. А затем вывел свою уникальную строку: "[Model] переключился на электротягу."
        public void StartEngine()
        {
       
        }
    }
}
