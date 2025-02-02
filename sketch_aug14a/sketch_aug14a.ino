#include <OneWire.h>
#include <DallasTemperature.h>

// Chân kết nối với DS18B20
#define ONE_WIRE_BUS D2

// Thiết lập thư viện OneWire
OneWire oneWire(ONE_WIRE_BUS);

// Thiết lập thư viện DallasTemperature
DallasTemperature sensors(&oneWire);

void setup(void)
{
  // Khởi tạo giao tiếp nối tiếp
  Serial.begin(9600);
  // Khởi tạo cảm biến
  sensors.begin();
}

void loop(void)
{
  // Yêu cầu đọc nhiệt độ từ cảm biến
  sensors.requestTemperatures();
  
  // Đọc nhiệt độ từ cảm biến DS18B20
  float temperatureC = sensors.getTempCByIndex(0);
  
  // Kiểm tra nếu giá trị là -127 thì có thể do cảm biến không được nhận diện
  if (temperatureC == -127.00) {
    Serial.println("Loi cam bien! Kiem tra lai ket noi.");
  } else {
    Serial.print("Nhiet Do: ");
    Serial.print(temperatureC);
    Serial.println(" °C");
  }
  
  // Đợi 0.5 giây trước khi đọc lại
  delay(500);
}
