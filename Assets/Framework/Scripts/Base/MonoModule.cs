namespace Apotocalypto_Framework{
    public class MonoModles:UnityEngine.MonoBehaviour{
        void Awake(){
            Base.MonoModuleCount++;
            Base.ModuleCount++;
        }
        void OnDestroy(){
            Base.MonoModuleCount--;
            Base.ModuleCount--;
        }
    }
}