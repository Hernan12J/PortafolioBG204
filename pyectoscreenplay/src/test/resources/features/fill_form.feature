# Autor: hhern
# Fecha: 12/19/2024

Feature: Fill Form Functionality

  Background:
    Given "Hernan" open the site web

  @successful
  Scenario: Fill out the form and submit it
    And Validar menu de Forms
    When Selecciona Practice From
    And Llena el formulario con los datos requeridos