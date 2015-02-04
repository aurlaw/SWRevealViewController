XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/SWRevealViewControllerSDK.xcodeproj
TARGET=SWRevealViewControllerSDK

all: libSWRevealViewControllerSDK.a

libSWRevealViewControllerSDK-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libSWRevealViewControllerSDK-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libSWRevealViewControllerSDK-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libSWRevealViewControllerSDK-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libSWRevealViewControllerSDK.a: libSWRevealViewControllerSDK-i386.a libSWRevealViewControllerSDK-armv7.a libSWRevealViewControllerSDK-armv7s.a libSWRevealViewControllerSDK-arm64.a
	lipo -create -output $@ $^

sharpie:
	sharpie bind --output=SWRevealViewController --namespace=SWRevealViewController --sdk=iphoneos8.1 SWRevealViewControllerSDK/SWRevealViewController.h --unified

clean:
	-rm -f *.a *.dll