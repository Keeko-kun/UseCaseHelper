using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{

    public class Element
    {

        private List<Actor> actors = new List<Actor>();
        private List<Bitmap> images = new List<Bitmap>();
        private int currentlySelected;

        public Element()
        {

        }

        public void AddActor(Actor newActor)
        {
            actors.Add(newActor);
        }

        public int GetActorLength
        {
            get
            {
                return actors.Count;
            }
        }

        public Actor GetActor(int i)
        {
            return actors[i];
        }

        public Bitmap GetBitmap()
        {
            return images[currentlySelected];
        }

        public void AddImage(Bitmap newImage)
        {
            images.Add(newImage);
        }

        public int GetBitmapLength
        {
            get
            {
                return images.Count;
            }
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

        public void SetCurrentElement(int newElementSelection)
        {
            currentlySelected = newElementSelection;
        }
    }
}
