using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommandPattern.Practice2
{

    public class CommandRecorder : MonoBehaviour
    {

        public Command keyQ,keyW,keyE,keyR,keyT,keyY;

        private void Start()
        {
            keyQ = new Print1Command();
            keyW = new Print2Command();
            keyE = new Print3Command();
            keyR = new Print4Command();
            keyT = new Print5Command();
            keyY = new PrintSeparatorCommand();

        }

        private List<Command> commandRecords = new List<Command>();


        private void Update()
        {

            if (Input.GetKey(KeyCode.Space)&&!recordReplaying)
            {
                StartCoroutine(ReplayRoutine());
            }
            else if (recordReplaying)
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                keyQ.Execute();
                commandRecords.Add(keyQ);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                keyW.Execute();
                commandRecords.Add(keyW);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                keyE.Execute();
                commandRecords.Add(keyE);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                keyR.Execute();
                commandRecords.Add(keyR);
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                keyT.Execute();
                commandRecords.Add(keyT);
            }
            else if (Input.GetKeyDown(KeyCode.Y))
            {
                keyY.Execute();
                commandRecords.Add(keyY);
            }
        }

        private bool recordReplaying;
        private int currentRecordIndex;
        private IEnumerator ReplayRoutine()
        {
            recordReplaying = true;
            while (true)
            {
                if (commandRecords.Count != 0)
                    commandRecords[currentRecordIndex].Execute();

                currentRecordIndex++;
                yield return new WaitForSeconds(0.5f);
                if (currentRecordIndex >= commandRecords.Count)
                {
                    currentRecordIndex = 0;
                    recordReplaying = false;
                    yield break;
                }

            }

        }

    }




}
