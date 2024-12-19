# Autor: hhern
# Fecha: 12/17/2024
Feature: : Abrir una pagina web

  Background:
    Given "Hernan" open the site web

@successful
Scenario: Validar ID CARD ELEMENTS
And validar funcion del menu de elementos
When selecciona aleatoriamente alguna de las subfunciones
Then  visualizara en la cabecera el nombre de la opcion elegida
