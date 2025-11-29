using System.Collections.Generic;

namespace CobolStudio.src.models.core
{
    internal class BaseModel
    {
        List<BaseModel> _children = new List<BaseModel>();

        public virtual void AddChild(BaseModel child)
        {
            _children.Add(child);
        }

        public override string ToString()
        {
            return $"Model: {GetType().Name} Children:  {_children.Count}";
        }
    }
}
