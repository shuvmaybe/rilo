# Creating Your First Theme
Since I was too lazy to write a theme creator for *rilo*, you will have to create a theme *(- or icon pack -)* manually.

### 1. Learn the structure
A theme is structured into a `manifest` table and a table containing [keys](https://github.com/shuvmaybe/rilo/blob/main/mds/KEYS.md).

The manifest contains 3 values:
- `name`: Name of the theme
- `desc`: Description of the theme
- `author`: Author of the theme

Which are structured like this:
```json
    "manifest": {
        "name": "Theme Name",
        "desc": "Write something interesting about your theme here.",
        "author": "shuv"
    },
```
Loading this will cause *rilo* to ignore your JSON, because we haven't added the required `keys` yet.

*Please read [this documentation](https://github.com/shuvmaybe/rilo/blob/main/mds/KEYS.md) on what keys are, and how to use them.*

### 3. Finding what to change
### Finding your Roblox Studio install:

**Way 1: Windows Explorer**

- Open Windows Explorer
- Go to `C:\Users\<user>\AppData\Local\Roblox\Versions\`
- Go to the folder that was last modified. It should start with `version-...`

There you will find `RobloxStudioBeta.exe` and other executables related to Studio.

**Way 2: Roblox Studio Shortcut**

This one is easy if you have a Roblox Studio shortcut on your desktop already.

- Right click the Roblox Studio shortcut
- Click the button that corresponds to opening the location of the original file


If you successfully found your Roblox Studio install, we can start looking for what we want to change.

Head over to the `content` folder and just go looking for what you want to change.

For this tutorial I will go to `\content\studio_svg_textures\Lua\TerrainEditor\Dark\Large\` because it is easy to find then in Roblox Studio.

> [!NOTE]  
> If your Roblox Studio is in light mode, go to `Light` instead of `Dark` in the directories.

We will try to change the `Draw.png` file.

### 4. Setting up the keys
If you don't have your JSON set up already, you can use this example:
```json
{
    "manifest": {
        "name": "Draw Changer",
        "desc": "Changes the Draw icon in the Terrain Editor.",
        "author": "UserNameHere"
    },
    "keys": {

    }
}
```

There are no keys set yet, you will do that.

Since we want to add `C:\Users\<user>\AppData\Local\Roblox\Versions\version-...\content\studio_svg_textures\Lua\TerrainEditor\Dark\Large\Draw.png` as a key and change it, we will first specify the path correctly.

Since *rilo* starts straight from the folder where RobloxStudioBeta.exe is (if you specificed the .exe correctly when rilo asked you for it), you don't need to write out the entire path. Remove everything from before `studio_svg_textures` in the path.

e.g. : `C:\Users\<user>\AppData\Local\Roblox\Versions\version-...\content\studio_svg_textures\Lua\TerrainEditor\Dark\Large\Draw.png` becomes `studio_svg_textures\Lua\TerrainEditor\Dark\Large\Draw.png`.

Now we double the amount of backslashes:
`studio_svg_textures\\Lua\\TerrainEditor\\Dark\\Large\\Draw.png`

Great! We have now set 1 (path) out of 2 params required for a valid key.

Add a new entry to `keys` in your JSON like this:

```json
"studio_svg_textures\\Lua\\TerrainEditor\\Dark\\Large\\Draw.png": "",
```
### 5. Setting up the URL

In the previous example, you can see the second value is not set up yet. It's an empty string.

The second value will be an URL, *rilo* takes the URL, creates a backup of the original image, downloads the one from the URL and uses that to replace the original one.

Just simply make an image of what you want, edit one, make one off scratch or edit the existing one and upload it to some service like [ImgBB](https://imgbb.com/) or a public Github repository.


> [!CAUTION]  
> If your ImgBB image doesn't work, it could be because of an invalid link. You must get the link with the image and its extension.
>
> Incorrect link : https://ibb.co/MNT2j5k
>
> Open the link, Right Click the image you uploaded, press "Copy Image Link" and then use that one.
>
> Correct link: https://i.ibb.co/C0d1XsK/cabicous1.png

Now that we have our image link, we can put it as the second value in our key.
```json
"studio_svg_textures\\Lua\\TerrainEditor\\Dark\\Large\\Draw.png": "https://i.ibb.co/C0d1XsK/cabicous1.png",
```
Now your whole JSON file should look something like this:
```json
{
    "manifest": {
        "name": "Draw Changer",
        "desc": "Changes the Draw icon in the Terrain Editor.",
        "author": "UserNameHere"
    },
    "keys": {
        "studio_svg_textures\\Lua\\TerrainEditor\\Dark\\Large\\Draw.png": "https://i.ibb.co/C0d1XsK/cabicous1.png",
    }
}
```

## Installation of your finished theme
We have finished making our theme. Now just save the file with any name you like with the extension being, *well of course*, `.JSON`.

Now we can open *rilo*, press the *rilo* button at the top and pressing **Load .JSON**.

Then, select your JSON file that you just saved.

Verify if the manifest is correct, check whether you want to open Studio after installation or not, and then press ***Install***.

Select your `RobloxStudioBeta.exe`.

Wait for *rilo* to finish installing.

## Testing

Now that we have installed our theme/icon pack/whatever you want to call it, we can launch Roblox Studio to see it.

If you specified the **Open Roblox Studio after Installation** checkbox, wait for Studio to open.

If you didn't, just open studio normally.

If you followed my tutorial and also used the same path for the icon, you can see your changes by doing this:
- Open any place
- Go to 'View' on top
- Click 'Terrain Editor'
- Press 'Edit' in the Terrain Editor
- Look if the **Draw** button has changed.

If it did, bravo! Now you can add more entries to your `keys` table to expand your theme even further!

## Uninstallation

If you are testing your theme and went straight to your JSON and started changing it, ***GO BACK!***

You need to uninstall/unload your first theme in order to add more stuff; because if you don't, you will break your Studio assets.

Follow these steps:
- Open *rilo*
- Press the *rilo* button at the top
- Press **Unload .JSON**
- Select the .json file you first loaded in the **Testing** part
- Press **Yes**
- Select your `RobloxStudioBeta.exe`
- Wait till it uninstalls

---

Now, start adding more entries to your `keys` until you finish fleshing out your cool new icon pack / theme!

If Roblox Studio updates ever again, just load your .json again to re-install all icons.

Thank you, have fun :-)

