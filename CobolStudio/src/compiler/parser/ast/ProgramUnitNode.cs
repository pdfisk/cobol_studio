using CobolStudio.src.compiler.core;
using CobolStudio.src.models;
using CobolStudio.src.models.core;
using CobolStudio.src.models.divisions;
using static Cobol85Parser;

namespace CobolStudio.src.parser.ast
{
    public class ProgramUnitNode : AstNode
    {
        ProgramUnitContext _context;

        public ProgramUnitNode(ProgramUnitContext context)
        {
            _ctx = _context = context;
        }

        public override BaseModel GenerateSelf(CompilerUtil compilerUtil)
        {
            var model = new ProgramUnitModel(this);
            for (var i = 0; i < ChildCount(); i++)
            {
                var child = GetChild(i);
                var childModel = child.Generate(compilerUtil);
                if (childModel is IdentificationDivisionModel)
                {
                    model.identificationDivisionModel = (IdentificationDivisionModel)childModel;
                }
                else if (childModel is EnvironmentDivisionModel)
                {
                    model.environmentDivisionModel = (EnvironmentDivisionModel)childModel;
                }
                else if (childModel is DataDivisionSectionModel)
                {
                    model.dataDivisionModel = (DataDivisionSectionModel)childModel;
                }
                else if (childModel is ProcedureDivisionModel)
                {
                    model.procedureDivisionModel = (ProcedureDivisionModel)childModel;
                }
                if (childModel != null)
                {
                    model.AddChild(childModel);
                }
            }
            return model;
        }


    }
}
