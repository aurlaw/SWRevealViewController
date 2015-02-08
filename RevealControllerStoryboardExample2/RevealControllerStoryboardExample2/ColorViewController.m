//
//  ColorViewController.m
//  RevealControllerStoryboardExample
//
//  Created by Nick Hodapp on 1/9/13.
//  Copyright (c) 2013 CoDeveloper. All rights reserved.
//

#import "ColorViewController.h"

@interface ColorViewController ()
@property (nonatomic) IBOutlet UIBarButtonItem* revealButtonItem;
@end

@implementation ColorViewController

- (void)viewDidLoad
{
    [super viewDidLoad];
    [self customSetup];
}


- (void)customSetup
{
    SWRevealViewController *revealViewController = self.revealViewController;
    if ( revealViewController )
    {
        [self.revealButtonItem setTarget: revealViewController];
        [self.revealButtonItem setAction: @selector( revealToggle: )];
        [self.navigationController.navigationBar addGestureRecognizer:revealViewController.panGestureRecognizer];
    }
    
    _label.text = _text;
    _label.textColor = _color;

	
		// START: Atrributed Navigation title (Custom Font: BenchNine-Bold.ttf)
	NSDictionary *attributes = @{NSForegroundColorAttributeName: [UIColor blackColor],
							  NSFontAttributeName: [UIFont fontWithName:@"BenchNine-Bold" size:40.0]};

	
	NSDictionary * wordToColorMapping = @{@"color ": [UIColor blackColor], _text: _color};
	NSMutableAttributedString *strTitle = [[NSMutableAttributedString alloc] initWithString:@""];
	for (NSString *word in wordToColorMapping) {
		 UIColor *color = [wordToColorMapping objectForKey:word];
		NSMutableDictionary *att = [[NSMutableDictionary alloc] initWithDictionary:attributes];
		[att setObject:color forKey:NSForegroundColorAttributeName];
		
		 NSAttributedString * subString = [[NSAttributedString alloc] initWithString:[word lowercaseString] attributes:att];
		 [strTitle appendAttributedString:subString];
	}
	UILabel *titleLabel = [UILabel new];
	titleLabel.attributedText = strTitle;// [[NSAttributedString alloc] initWithString:_text attributes:attributes];
	[titleLabel sizeToFit];
	self.navigationItem.titleView = titleLabel;
	
		// END: Atrributed Navigation title
	
}

#pragma mark state preservation / restoration

- (void)encodeRestorableStateWithCoder:(NSCoder *)coder
{
    NSLog(@"%s", __PRETTY_FUNCTION__);
    
    // Save what you need here
    [coder encodeObject: _text forKey: @"text"];
    [coder encodeObject: _color forKey: @"color"];

    [super encodeRestorableStateWithCoder:coder];
}


- (void)decodeRestorableStateWithCoder:(NSCoder *)coder
{
    NSLog(@"%s", __PRETTY_FUNCTION__);
    
    // Restore what you need here
    _color = [coder decodeObjectForKey: @"color"];
    _text = [coder decodeObjectForKey: @"text"];
    
    [super decodeRestorableStateWithCoder:coder];
}


- (void)applicationFinishedRestoringState
{
    NSLog(@"%s", __PRETTY_FUNCTION__);
    
    // Call whatever function you need to visually restore
//    [self customSetup];
}

@end
