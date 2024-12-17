Feature: Get geographical data of country

  Background:
    * url api.baseUrl
    * path geoPath = '/timezoneJSON'
    * params {username: "#(user.name)" , formatted: true, lat: #(latitude), lng: #(longitude)}
    * def responseSuccessful = read("successful-response-get.json")
    * def responseFailParameter = read("fail-parsing-parameter-get.json")
    * def responseDataPanama = read("response-data-prueba-get.json")

    Scenario Outline:Get geographical data of country

      When method get
      Then status 200
      And match $ == responseSuccessful

      Examples:
        |latitude|longitude|
        |8.9833 |-79.5167 |
        |4.2    |-72.5    |
        |8      |-8f      |
        |-75    |80       |

  Scenario Outline:Get geographical data of Panama

    When method get
    Then status 200
    And match $ == responseDataPanama

    Examples:
      |latitude|longitude|
      |8.9833 |-79.5167 |

  Scenario Outline:Get geographical data fail

    When method get
    Then status 200
    And match $ == responseFailParameter

    Examples:
      |latitude|longitude|
      |a      |-79.5167 |
      |1      |s        |
      |]      |12       |
      |3      |-a25f    |

  Scenario Outline:Get geographical data dont have data

    When method get
    Then status 200
    And match $ == {"status": {"message": "no timezone information found for lat/lng","value": 15}}

    Examples:
      |latitude|longitude|
      |90 |34|