Feature: Search pet

  Background:
    * url 'https://petstore.swagger.io'

    Scenario: search a pet
      * def addAPetRequest =
      """
              {
          "id": 0,
          "category": {
            "id": 0,
            "name": "string"
          },
          "name": "doggie",
          "photoUrls": [
            "string"
          ],
          "tags": [
            {
              "id": 0,
              "name": "string"
            }
          ],
          "status": "available"
        }
      """

      Given path '/v2/pet'
      And request addAPetRequest
      When method post
      Then status 200

      * def petID = response.id
      * print 'pet ID:' , petID

      Given path '/v2/pet/', petID
      When method get
      Then status 200
      And match response.id == petID

    Scenario: Validar estructura de respuesta
      * def addAPetRequest =
      """
              {
          "id": 0,
          "category": {
            "id": 0,
            "name": "string"
          },
          "name": "doggie",
          "photoUrls": [
            "string"
          ],
          "tags": [
            {
              "id": 0,
              "name": "string"
            }
          ],
          "status": "available"
        }
      """

      Given path '/v2/pet'
      And request addAPetRequest
      When method post
      Then status 200

      And match response ==
      """
      {
  "id": #number,
  "category": {
    "id": 0,
    "name": "string"
  },
  "name": "#string",
  "photoUrls": [
    "string"
  ],
  "tags": [
    {
      "id": 0,
      "name": "string"
    }
  ],
  "status": "available"
}
      """
