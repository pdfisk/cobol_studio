using Antlr4.Runtime;
using CobolStudio.src.compiler.core;
using CobolStudio.src.models.core;
using IronPython.Runtime.Operations;
using MyChatDB;
using System.Collections.Generic;

namespace CobolStudio.src.parser.ast
{
    internal class AstNode
    {
        public List<AstNode> _children = new List<AstNode>();
        public RuleContext _ctx;
        public AstNode _parent;

        public virtual void AddChild(AstNode child)
        {
            _children.Add(child);
            child._parent = this;
        }

        public int ChildCount()
        {
            return _children.Count;
        }

        public virtual BaseModel Generate(CompilerUtil compilerUtil)
        {
            var model = GenerateSelf(compilerUtil);
            GenerateChildren(model, compilerUtil);
            return model;
        }

        public virtual void GenerateChildren(BaseModel parent, CompilerUtil compilerUtil)
        {
            for (var i = 0; i < ChildCount(); i++)
            {
                var child = GetChild(i);
                var childModel = child.Generate(compilerUtil: compilerUtil);
                if (childModel == null) {
                    PrintLn($"Generated null child model: {child.GetType().Name}");
                }
                if (childModel != null && parent != null)
                {
                    parent.AddChild(childModel);
                }
            }
        }

        public virtual BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            PrintLn($"GenerateSelf {GetType().Name}: {ChildCount()}");
            return null;
        }

        public AstNode FirstChild()
        {
            if (_children.Count > 0)
                return _children[0];
            return null;
        }

        public AstNode GetChild(int index)
        {
            return _children[index];
        }

        public void PrintLn(string message)
        {
            TranscriptWindow.GetInstance().PrintLn(message);
        }

        public virtual string ToIndentedString(string indent = "")
        {
            string result = indent + ToString() + "\n";
            foreach (var child in _children)
            {
                result += child.ToIndentedString(indent + "  ");
            }
            return result;
        }

        public override string ToString()
        {
            return GetType().Name;
        }

        public string ToTree()
        {
            return ToIndentedString();
        }

        public string ToContextTree(CobolParser parser)
        {
            return _ctx.ToStringTree(parser);
        }
    }
}
