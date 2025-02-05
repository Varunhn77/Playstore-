using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playstore;

namespace Playstore
{
    public abstract class Vehicle
    {
        public abstract void starEngine();

        public abstract void stopEngine();
    }
}
public class Car : Vehicle
{
    public override void starEngine()
    {
        throw new NotImplementedException();
    }

    public override void stopEngine()
    {
        throw new NotImplementedException();
    }
}
public class MotorCycle : Vehicle
{
    public override void starEngine()
    {
        throw new NotImplementedException();
    }

    public override void stopEngine()
    {
        throw new NotImplementedException();
    }
}
