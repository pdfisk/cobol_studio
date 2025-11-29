using System.Collections.Generic;

namespace CobolStudio.src.models.core
{
    internal class BaseModel
    {
        List<BaseModel> _children = new List<BaseModel>();

        public void AddChild(BaseModel child)
        {
            _children.Add(child);
        }
    }
}
