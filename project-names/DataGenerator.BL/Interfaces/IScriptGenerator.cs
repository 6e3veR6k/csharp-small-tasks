using DataGenerator.Data.Models;

namespace DataGenerator.BL.Interfaces
{
    public interface IScriptGenerator
    {
        UserEntity GenerateUser();
        string GetValueString(UserEntity user);
        string CreateScript(int entityCount);
        string GetInsertLine();
    }
}
