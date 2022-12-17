
namespace Apotocalypto_Framework{

    //BaseModel for the framework
    public class Module{
        public Module(){
            Base.ModuleCount ++;
        }

        ~Module(){
            Base.ModuleCount --;
        }
    }

}