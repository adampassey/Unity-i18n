# i18n
i18n Package for Unity

## Installation & Usage

Download or clone the repository and import `i18n.unitypackage` by selecting `Assets -> Import Package -> Custom Package`. 
Create `StreamingAssets` directory in `Assets`, and a subdirectory `Lang`. Then create your first localization file: `en-US.json`
in the following format:

```json
{
	"strings": [
		{
			"key": "someKey",
			"value": "This is some value"
		},
		{
			"key": "hello",
			"value": "Hello, {0}"
		},
		{
			"key": "introduction",
			"value": "Hello, {0}, how are you {1}?"
		}
	]
}
```
Drop an `i18n - Loader` into your scene and specify:

* **Lang Directory**: The directory of your language files
* **Default Lang**: The language that will load by default
* **Load By Default**: Whether you want the loader to load on startup

Once your languages have been loaded you can easily use strings using `i18n.Strings` like so:

```c#
// retrieve a localized string by key
i18n.Strings.Get("key");

// retrieve a localized string by key and format it, the same as "Strings.Format("Hello, {0}!", "Adam");
i18n.Strings.Get("introduction", "Adam");
```
