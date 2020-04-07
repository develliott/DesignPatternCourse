using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns.DecoratorPattern.CodeProblem
{
    public class Artefact
    {

        private readonly string _name;

        private bool _hasError;

        private bool _isMain;

        public Artefact(string name)
        {
            _name = name;
        }

        public string Render()
        {
            //  The current implementation is not easily extensible. If tomorrow we need
            //  to support other special markers, we have to come back and modify this class.
            // 
            //  For example, if the project is under source control, we need to highlight
            //  the artefacts that are changed but not committed to the repository with a
            //  special marker.
            // 
            //  Similarly, if an artefact is excluded from the project, we may want to
            //  make the icon look disabled or semi-transparent.
            // 
            //  Every time we need to support a new marker, we have to come back and modify
            //  this class. Over time, the code in this class gets more and more convoluted
            //  with several if statements and additional fields.
            string errorIcon = _hasError ? "Error" : "";
            string mainIcon = _isMain ? "Main" : "";
            return $"{_name} {errorIcon} {mainIcon}";
        }

        public void SetHasError(bool hasError)
        {
            _hasError = hasError;
        }

        public void SetMain(bool main)
        {
            _isMain = main;
        }
    }
}
