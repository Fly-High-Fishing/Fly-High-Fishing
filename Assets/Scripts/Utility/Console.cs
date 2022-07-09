using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;

namespace Utility
{
    public class Console : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _Log;
        [SerializeField] private TMP_InputField _Input;
        [SerializeField] private TextMeshProUGUI _Autocomplete;

        private string _AutocompleteValue;

        private static Dictionary<string, Action<string[]>> _Commands = new Dictionary<string, Action<string[]>>()
        {
            { "firearrow", FireArrow },
            { "retrievearrow", RetrieveArrow }
        };

        private static void FireArrow(string[] args)
        {
            var arrow = GameObject.Find("Arrow").GetComponent<Arrow>();
            var type = arrow.GetType();
            var field = type.GetMethod("SetInFlight", BindingFlags.NonPublic | BindingFlags.Instance);
            field.Invoke(arrow, new object[]{});
            arrow.GetComponent<Rigidbody>().velocity += arrow.transform.forward * 10.0f;
        }

        private static void RetrieveArrow(string[] args)
        {
            var quiver = GameObject.Find("Quiver").GetComponent<Quiver>();
            var type = quiver.GetType();
            var method = type.GetMethod("TryRetrieveArrow", BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(quiver, new object[] { });
        }

        private void TryRunCommand(string input)
        {
            var splitInput = input.Split(' ');
            var commandString = splitInput[0];

            if (_Commands.TryGetValue(commandString.ToLower(), out var command))
            {
                command(splitInput.Skip(1).ToArray());
            }
            else
            {
                _Log.text += $"\nCommand '{commandString}' not found.";
            }
        }
        
        private void Awake()
        {
            _Input.onValueChanged.AddListener(CalculateAutocomplete);
            _Input.onSubmit.AddListener(TryRunCommand);
        }

        private static void CalculateAutocomplete(string input)
        {
            
        }
    }
}
