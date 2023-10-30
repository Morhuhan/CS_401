C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\

sn -T C:\Users\radio\Labs\C#\Работа_CS_401\Работа_CS_401\obj\Debug\libs\carlib\bin\Debug\carlib.dll

gacutil -i C:\Users\radio\Labs\C#\Работа_CS_401\Работа_CS_401\obj\Debug\libs\carlib\bin\Debug\carlib.dll

Как использовать GAC:
1) Создаем библиотеку carlib.dll. 
Для добавления в GAC нужно создать ключ. Подписать -> Создать -> keys.snk
Чтобы указать, что это первая версия библиотеки, заходим в файл AssemblyInfo.cs для 
данной библиотеки и указываем там версию 1.0.0.0. 
Строим сборку и добавляем в GAC.
2) Создаем вторую версию библиотеки. Указываем в AssemblyInfo.cs версию 2.0.0.0.
Добавляем в GAC. Теперь там две разные версии.
3) Чтобы выбрать, какую версию использовать, заходим конфиг файл проекта и указываем 
newVersion. (Токен узнаем из команды выше - sn....)

<configuration>
  <runtime>
	<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
		<dependentAssembly>
			<assemblyIdentity
				name="carlib"
				publicKeyToken="ad48fbd4e3602a96"
				culture="neutral" />
			<bindingRedirect
				oldVersion="2.0.0.0"
				newVersion="1.0.0.0" />
		</dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
