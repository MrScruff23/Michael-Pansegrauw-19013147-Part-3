using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class WizardUnit : Unit
    {
        public override void Combat(double damage)
        {
            throw new NotImplementedException();
        }

        public override bool DestroyUnit()
        {
            throw new NotImplementedException();
        }

        public override Direction DirectionOfEnemy(Unit enemy)
        {
            throw new NotImplementedException();
        }

        public override Unit FindClosestUnit(List<ButtonUnit> listOfUnits)
        {
            throw new NotImplementedException();
        }

        public override bool IsInRange(Unit u)
        {
            throw new NotImplementedException();
        }

        public override void Move(Direction d, int distance)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
