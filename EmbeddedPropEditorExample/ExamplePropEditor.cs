using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using ClientDependency.Core;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace EmbeddedPropEditorExample
{
    [PropertyEditor("Example", "Example Editor", "/App_Plugins/Example/Resource/editor.html", ValueType = "TEXT")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, "/App_Plugins/Example/Resource/controller.js")]
    public class ExamplePropEditor : PropertyEditor
    {
        protected override PreValueEditor CreatePreValueEditor()
        {
            return new ExamplePreValueEditor();
        }

        internal class ExamplePreValueEditor : PreValueEditor
        {
            public ExamplePreValueEditor()
            {
                //create the fields
                Fields.Add(new PreValueField()
                {
                    Description = "Enter the number of chars to limit on",
                    Key = "limit",
                    View = "requiredfield",
                    Name = "Number of chars"
                });
                
            }
        }
    }
}