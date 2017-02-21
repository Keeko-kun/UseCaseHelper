using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public enum drawMode
    {
        Actor,
        Case,
        Line
    }
    public class Element
    {

        private List<Actor> actors = new List<Actor>();
        private List<Line> lines = new List<Line>();
        private int currentlySelected;
        private drawMode currentMode;

        public Element()
        {

        }

        public void AddActor(Actor newActor)
        {
            actors.Add(newActor);
        }

        public void AddLine(Line newLine)
        {
            lines.Add(newLine);
        }

        public int GetActorLength
        {
            get
            {
                return actors.Count;
            }
        }

        public int GetLineLength
        {
            get
            {
                return lines.Count;
            }
        }

        public Actor GetActor(int i)
        {
            return actors[i];
        }

        public Line GetLine(int line)
        {
            return lines[line];
        }

        public int CurrentElement
        {
            get
            {
                return currentlySelected;
            }
            set
            {
                currentlySelected = value;
            }
        }

        public string GetDrawMode
        {
            get
            {
                return currentMode.ToString();
            }
        }

        public drawMode SetDrawMode
        {
            set
            {
                currentMode = value;
            }
        }

        public void SetCurrentElement(int newElementSelection)
        {
            currentlySelected = newElementSelection;
        }
    }
}
