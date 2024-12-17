Feature: Users

  Background:
    * url 'https://reqres.in'

  Scenario: get all users
    Given path '/api/users?page=2'
    When method get
    Then status 200

  Scenario: Create a user
    * def create_user_request =
      """
      {
        "name": "morpheus",
        "job": "leader"
      }
      """
    Given path '/api/users'
    And request create_user_request
    When method post
    Then status 201

    * def validarNombre = create_user_request.name
    * def validarTrabajo = create_user_request.job

    And match response.name == validarNombre
    And match response.job == validarTrabajo
