using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302203122
{
    internal class PosisiKarakterGame
    {
        //membuat macam2 state dan aksi yang dilakukan
        public enum State {Terbang,Berdiri,Jongkok,Tengkurap }
        public enum Trigger { TombolW,TombolS,TombolX}

        //state saat ini
        public State currentState = State.Berdiri;

        //membuat kelas baru untuk transisi
        public class Transition
        {
            public State prevState, nextState;
            public Trigger trigger;

            public Transition(State prevState, State nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }

        }

        //array dari kelas Transition untuk mengisi semua kemungkinan state dan trigger
        Transition[] posisiKarakter =
        {
            new Transition(State.Berdiri, State.Terbang, Trigger.TombolW),
            new Transition(State.Terbang, State.Berdiri, Trigger.TombolS),
            new Transition(State.Jongkok, State.Berdiri, Trigger.TombolW),
            new Transition(State.Berdiri, State.Jongkok, Trigger.TombolS),
            new Transition(State.Tengkurap, State.Jongkok, Trigger.TombolW),
            new Transition(State.Jongkok, State.Tengkurap,Trigger.TombolS),
            new Transition(State.Terbang, State.Jongkok, Trigger.TombolX)

            };

        public State GetNextState(State prev, Trigger trigger)
        {
            State currentState = prev;
            for (int i = 0; i < posisiKarakter.Length; i++)
            {
                if (posisiKarakter[i].prevState == prev && posisiKarakter[i].trigger == trigger)
                {
                    currentState = posisiKarakter[i].nextState;
                }
            }
            return currentState;
        }
        public void activeTrigger(Trigger trigger)
        {
            State nextState = GetNextState(currentState, trigger);
            currentState = nextState;

            if (currentState == State.Berdiri)
            {
                Console.WriteLine("Berdiri");
                Console.WriteLine("posisi standby");
            }
            else if (currentState == State.Terbang)
            {
                Console.WriteLine("Terbang");
            }
            else if (currentState == State.Tengkurap)
            {
                Console.WriteLine("Tengkurap");
                Console.WriteLine("Posisi istirahat");
            }
            else if (currentState == State.Jongkok)
            {
                Console.WriteLine("Tengkurap");
            }
        }

    }
}






