//创建者:Icarus
//手动滑稽,滑稽脸
//ヾ(•ω•`)o
//https://www.ykls.app
//2019年09月17日-00:49
//CabinIcarus.SkillSystem.Runtime

using CabinIcarus.IcSkillSystem.Runtime.Buffs.Entitys;

namespace CabinIcarus.IcSkillSystem.Runtime.Buffs.Com
{
    public interface IEntityFilter
    {
        /// <summary>
        /// 实体过滤buff
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Filter(IEntity entity);
    }
}