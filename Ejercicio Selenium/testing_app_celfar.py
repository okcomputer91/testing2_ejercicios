from selenium import webdriver
from selenium.webdriver.common.by import By
import time

# 1. Configura el navegador para las pruebas
driver = webdriver.Chrome()
driver.maximize_window()

try:
    # 2. Abrir la página del conversor CelFar
    driver.get("https://nahual.github.io/qc-celfar/")  # el driver llama a la url
    print("Pagina cargada correctamente")
    time.sleep(2)  # Esperar a que cargue

    # localizados los elementos que se ponen a prueba
    entrada = driver.find_element(By.CSS_SELECTOR, "input#input.input")
    boton = driver.find_element(By.CSS_SELECTOR, "input.button[value='convertir!']")
    resultado = driver.find_element(By.CSS_SELECTOR, "span#output.output")

    # PRUEBA 1: Conversion correcta a probar: (45°C → 113°F) teniendo en cuenta la informacion de https://nahual.github.io/qc-celfar/especificaciones.html
    print("\n=== Prueba 1: Conversion correcta ===")
    entrada.clear()
    entrada.send_keys("45")
    boton.click()
    time.sleep(1)
    
    if "113" in resultado.text:
        print("✓ PASÓ: 45°C se convirtió correctamente a 113°F")
    else:
        print(f"✗ FALLÓ: Esperaba '113' pero obtuve '{resultado.text}'")

    # PRUEBA 2: Valor invalido (no numerico)
    print("\n=== Prueba 2: caracter invalido ===")
    entrada.clear()
    entrada.send_keys("abc")
    boton.click()
    time.sleep(1)
    
    if "invalid" in resultado.text.lower():
        print("✓ PASÓ: Se detecto correctamente un caracter invalido")
    else:
        print(f"✗ FALLÓ: Esperaba mensaje de error pero obtuve '{resultado.text}'")

    # PRUEBA 3: Numero invalido (9999999)  
    print("\n=== Prueba 3: Numero invalido (9999999) ===")
    entrada.clear()
    entrada.send_keys("9999999")
    boton.click()
    time.sleep(1)
    
    if "invalid" in resultado.text.lower() or "no válido" in resultado.text.lower():
        print("✓ PASÓ: Detectó '9999999' como invalido")
    else:
        print(f"✗ FALLÓ: Esperaba error pero obtuve '{resultado.text}'")

except Exception as e:
    print(f"\n ERROR: {str(e)}")

finally:
    driver.quit()
    print("\nPruebas terminadas. Navegador cerrado.")