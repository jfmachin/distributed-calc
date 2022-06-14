from time import sleep

import requests, random

url = "http://webapi:80/api/calc/"

while True:
  try:
    payload = {
      "N1": random.randint(1, 999),
      "N2": random.randint(1, 999),
      "operation": random.choice(["-", "+", "*", "/"])
    }
    sleep(0.1)
    requests.post(url, json=payload)
    print(payload["N1"], payload["operation"], payload["N2"])
  except:
    print("Cant connect to API")