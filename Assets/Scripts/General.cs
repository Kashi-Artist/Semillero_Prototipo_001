using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;



public class General : MonoBehaviour
{
    

    public TMP_Text caja_pregunta;
    public Button respuesta_01;
    public Button respuesta_02;
    public Button respuesta_03;
    public string [] preguntas = {"Pregunta 1 A", "Pregunta 1 B", "Pregunta 2 A", "Pregunta 2 B", "Pregunta 3 A", "Pregunta 3 B"};

    public string [] respuestas = {"Respuesta 1 A", "Respuesta 1 B ", "Respuesta 1 C","Respuesta 2 A", "Respuesta 2 B", "Respuesta 2 C","res_3_1", "res_3_2", "res_3_3",
    "res_4_1", "res_4_2", "res_4_3","res_5_1", "res_5_2", "res_5_3","res_6_1", "res_6_2", "res_6_3"};

    int contador = 0;
    void Start()
    {
    update_boxes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateBox(string pregunta){
        caja_pregunta.text = pregunta;
        //Debug.Log("Pregunta Cargada Correctamente");
    }

    public void updateButtons(string res_01, string res_02, string res_03){
        TMP_Text texto_respuesta_01 = respuesta_01.GetComponentInChildren<TMP_Text>();
        texto_respuesta_01.text = res_01;

        TMP_Text texto_respuesta_02 = respuesta_02.GetComponentInChildren<TMP_Text>();
        texto_respuesta_02.text = res_02;

        TMP_Text texto_respuesta_03 = respuesta_03.GetComponentInChildren<TMP_Text>();
        texto_respuesta_03.text = res_03;
    }

    public void update_boxes(){
    System.Random rnd = new System.Random();
    Debug.Log("Contador es: "+ contador);
    int pregunta_1 = rnd.Next(1,3);
    int pregunta_2 = rnd.Next(1,3);
    int pregunta_3 = rnd.Next(1,3);


    respuesta_01.onClick.AddListener(boton_1_press);
    respuesta_02.onClick.AddListener(boton_2_press);
    respuesta_03.onClick.AddListener(boton_3_press);



    if (contador == 0){
        if (pregunta_1 == 1){
            //Debug.Log("Pregunta 1_1");
            updateBox(preguntas[0]);
            updateButtons(respuestas[0], respuestas[1], respuestas[2]);
        }
        else if (pregunta_1 == 2){
            //Debug.Log("Pregunta 1_2");
            updateBox(preguntas[1]);
            updateButtons(respuestas[3], respuestas[4], respuestas[5]);
    }
    }else if (contador == 1){
        if (pregunta_2 == 1){
            //Debug.Log("Pregunta 2_1");
            updateBox(preguntas[2]);
            updateButtons(respuestas[6], respuestas[7], respuestas[8]);
        }
        else if (pregunta_1 == 2){
            //Debug.Log("Pregunta 1_2");
            updateBox(preguntas[3]);
            updateButtons(respuestas[9], respuestas[10], respuestas[11]);
    }  
    }else if (contador == 2){
        if (pregunta_3 == 1){
            //Debug.Log("Pregunta 2_1");
            updateBox(preguntas[4]);
            updateButtons(respuestas[12], respuestas[13], respuestas[14]);
        }
        else if (pregunta_3 == 2){
            //Debug.Log("Pregunta 1_2");
            updateBox(preguntas[5]);
            updateButtons(respuestas[15], respuestas[16], respuestas[17]);
    }
    }else{
        Debug.Log("No hay preguntas");
    }

    contador++;
    }

    public void boton_1_press(){
        //Debug.Log("Boton 1 presionado");
        update_boxes();
    }

    public void boton_2_press(){
        //Debug.Log("Boton 2 presionado");
        update_boxes();
    }

    public void boton_3_press(){
        //Debug.Log("Boton 3 presionado");
        update_boxes();
    }
}

